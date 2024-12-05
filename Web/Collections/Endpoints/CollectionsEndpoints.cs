using System.Security.Claims;
using Collections.Data;
using Collections.Dtos;
using Collections.Models;
using Collections.Payloads;
using Collections.Repositories;
using Collections.Repositories.ElasticSearch;
using KRK_Shared.Helpers;
using KRK_Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Bindings;
using Shared.Clients;

namespace Collections.Endpoints;

public static class CollectionsEndpoints
{
    public static void MapCollectionsEndpoints(this WebApplication app)
    {
        app.MapGet("/api/collections", GetCollections)
            .RequireAuthorization();

        app.MapGet("/api/collections/collections-to-add-recipe/{recipeId}", FetchMyCollectionsToAddRecipe)
            .RequireAuthorization();

        app.MapPost("/api/collections/{collectionId}/add-recipe", AddRecipeToCollection)
            .RequireAuthorization();

        app.MapPost("/api/collections/{collectionId}/remove-recipe", RemoveRecipeToCollection)
            .RequireAuthorization();
    }

    private static async Task<IResult> RemoveRecipeToCollection(HttpContext httpContext, Guid collectionId,
        [FromBody] AddRemoveRecipeToCollectionPayload payload,
        ClaimsPrincipal user,
        CollectionsDbContext context,
        CollectionsRepository collectionsRepository,
        RecipesRepository recipesRepository,
        CancellationToken cancellationToken
    )
    {
        // Check if collection exists and current user is the one who created
        var collection = await collectionsRepository.GetById(collectionId, cancellationToken);
        if (collection == null) return Results.NotFound();
        if (collection.CreatorId != user.GetUserId()) return Results.Unauthorized();

        var recipe = await recipesRepository.GetById(payload.RecipeId, cancellationToken);
        if (recipe == null) return Results.NotFound();

        collection.Recipes.Remove(recipe);

        await context.SaveChangesAsync(cancellationToken);

        return Results.Ok();
    }

    private static async Task<IResult> AddRecipeToCollection([FromRoute] Guid collectionId,
        [FromBody] AddRemoveRecipeToCollectionPayload payload,
        ClaimsPrincipal user,
        CollectionsDbContext context,
        CollectionsRepository collectionsRepository,
        CancellationToken cancellationToken
    )
    {
        // Check if collection exists and current user is the one who created
        var collection = await collectionsRepository.GetById(collectionId, cancellationToken);
        if (collection == null) return Results.NotFound();
        if (collection.CreatorId != user.GetUserId()) return Results.Unauthorized();

        // check if recipe exists
        var recipe = await context.Recipes.Where(recipe => recipe.ExternalId == payload.RecipeId)
            .FirstOrDefaultAsync(cancellationToken);
        // If the recipe is null, add a new reference in the collections database
        if (recipe is null)
        {
            recipe = new RecipeModel
            {
                Id = payload.RecipeId,
                ExternalId = payload.RecipeId
            };

            await context.Recipes.AddAsync(recipe, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        // Add the recipe to the collection
        // This won't throw any error if the recipe is already added. It won't adding it again.
        collection.Recipes.Add(recipe);
        await context.SaveChangesAsync(cancellationToken);

        return Results.Ok();
    }

    private static async Task<IResult> FetchMyCollectionsToAddRecipe(
        Guid recipeId,
        [AsParameters] PaginationQueryParams queryParams,
        ClaimsPrincipal user,
        CollectionsDbContext context,
        ProfileDataClient profileClient,
        PicturesBasePath picturesBasePath,
        CollectionElasticSearchRepository collectionElasticSearchRepository,
        CancellationToken cancellationToken)
    {
        var userId = user.GetUserId()!.Value;

        IQueryable<CollectionModel> query = context
                .Collections
                .Include(collection => collection.Recipes)
            ;

        var paginationValue = new PaginationResponse<CollectionModel>();
        var pageNumber = queryParams.PageNumber;
        var pageSize = queryParams.PageSize;

        if (pageNumber.HasValue && pageSize.HasValue && queryParams.Search != null)
        {
            // Search from ElasticSearch
            var elasticSearchResponse = await collectionElasticSearchRepository.AdvancedSearchAsync(queryParams.Search,
                userId,
                pageNumber.Value,
                pageSize.Value,
                cancellationToken
            );

            // Ids of the collections to display
            var ids = elasticSearchResponse.Documents.Select(x => x.Id).ToList();

            query = query.Where(collection => ids.Contains(collection.Id));

            var data = await query.ToListAsync(cancellationToken);

            var totalPages = (int)Math.Ceiling(elasticSearchResponse.Total / (double)pageSize);

            paginationValue = new PaginationResponse<CollectionModel>
            {
                PageNumber = pageNumber.Value,
                PageSize = pageSize.Value,
                Data = data,
                TotalPages = totalPages
            };
        }
        else
        {
            // Search from ElasticSearch
            var elasticSearchResponse =
                await collectionElasticSearchRepository.SearchCollectionsAsync(queryParams.Search ?? "",
                    userId,
                    cancellationToken);

            // Ids of the collections to display
            var ids = elasticSearchResponse.Documents.Select(x => x.Id).ToList();

            query = query.Where(collection => ids.Contains(collection.Id));

            var data = await query.Where(collection => ids.Contains(collection.Id)).ToListAsync(cancellationToken);

            paginationValue = new PaginationResponse<CollectionModel>
            {
                Data = data
            };
        }

        // Fill profile information
        if (paginationValue.Data.Count > 0)
            try
            {
                // get the profile information to fill
                // Do it once because this the user own collections
                // Get the pictures url
                var profile = await profileClient.GetOne(userId, cancellationToken);

                paginationValue.Data = paginationValue.Data.Select(collection =>
                {
                    collection.Creator = profile;
                    return collection;
                }).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                // do nothing to keep the service usable.
            }

        paginationValue.Data = paginationValue.Data.Select(collection =>
        {
            HydrateCollectionImages(picturesBasePath, collection);
            return collection;
        }).ToList();

        // Convert to DTO
        var paginationValueDto =
            paginationValue.Data.Select(collection => { return new CollectionOwnerViewDto(collection, recipeId); })
                .ToList();

        var response = new PaginationResponse<CollectionOwnerViewDto>
        {
            Data = paginationValueDto,
            PageNumber = paginationValue.PageNumber,
            PageSize = paginationValue.PageSize,
            TotalPages = paginationValue.TotalPages
        };

        return Results.Ok(response);
    }

    private static async Task<IResult> GetCollections(
        Guid? tagId,
        CollectionsRepository collectionsRepository,
        ProfileDataClient profileDataClient,
        PicturesBasePath picturesBasePath,
        ClaimsPrincipal user,
        CancellationToken cancellationToken)
    {
        var userId = user.GetUserId();

        var collections = await collectionsRepository.Get(tagId, cancellationToken);

        var profilesIds = collections.Select(collection => collection.CreatorId).ToList();
        var profiles = await profileDataClient.GetManyProfiles(profilesIds, cancellationToken);

        var collectionsDtos = collections.Select(collection =>
        {
            var profile = profiles.FirstOrDefault(p => p.Id == collection.CreatorId);
            if (profile != null) collection.Creator = profile;

            HydrateCollectionImages(picturesBasePath, collection);

            return new CollectionViewDto(collection);
        });

        collectionsDtos = collectionsDtos.Where(collection => collection.Creator != null).ToList();

        return Results.Ok(collectionsDtos);
    }

    private static void HydrateCollectionImages(PicturesBasePath picturesBasePath, CollectionModel collection)
    {
        if (collection.CoverPath1 != null)
            collection.CoverPath1 = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Recipes + "/" +
                                    collection.CoverPath1;

        if (collection.CoverPath2 != null)
            collection.CoverPath2 = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Recipes + "/" +
                                    collection.CoverPath2;

        if (collection.CoverPath3 != null)
            collection.CoverPath3 = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Recipes + "/" +
                                    collection.CoverPath3;
    }
}