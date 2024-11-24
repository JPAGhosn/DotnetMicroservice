using KRK_Shared.Models;
using Recipes.Bindings;
using Recipes.Clients.Grpc;
using Recipes.Dtos.Recipe;
using Recipes.Repositories;

namespace Recipes.Endpoints;

public static class RecipesEndpoints
{
    public static void MapRecipes(this WebApplication app)
    {
        app.MapGet("/api/recipes", GetRecipes);
        app.MapGet("/api/recipes/{recipeId}", GetRecipe);
    }

    private static async Task<IResult> GetRecipe(
        Guid recipeId,
        RecipesRepository recipesRepository,
        PicturesBasePath picturesBasePath,
        ProfileDataClient profilesClient,
        CancellationToken cancellationToken)
    {
        return Results.NotFound();
        var recipe = await recipesRepository.GetById(recipeId, cancellationToken);
        if (recipe is null) return Results.NotFound();

        var recipeDto = new RecipeReadDto(recipe);

        return Results.Ok(recipeDto);
    }

    private static async Task<IResult> GetRecipes(
        int? pageNumber,
        int? pageSize,
        Guid? tagId,
        RecipesRepository recipesRepository,
        PicturesBasePath picturesBasePath,
        ProfileDataClient profilesClient,
        CancellationToken cancellationToken)
    {
        var paginatedResponse = await recipesRepository.GetAll(
            pageNumber ?? 1,
            pageSize ?? 6 * 6,
            tagId,
            cancellationToken
        );

        paginatedResponse.Data = paginatedResponse.Data.Select(recipe =>
        {
            if (recipe.Cover is not null)
                recipe.Cover = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Recipes + "/" + recipe.Cover;
            return recipe;
        }).ToList();

        var creatorsIds = paginatedResponse.Data.Select(recipe => recipe.CreatorId).Distinct().ToList();

        var profiles = await profilesClient.GetManyProfiles(creatorsIds, cancellationToken);

        paginatedResponse.Data = paginatedResponse.Data.Select(recipe =>
        {
            var profile = profiles.FirstOrDefault(p => p.Id == recipe.CreatorId);
            if (profile is not null) recipe.Creator = profile;
            return recipe;
        }).ToList();

        var recipesDtos = paginatedResponse.Data.Select(recipe => new RecipeViewDto(recipe)).ToList();


        return Results.Ok(new PaginationResponse<RecipeViewDto>
        {
            Data = recipesDtos,
            PageNumber = paginatedResponse.PageNumber,
            PageSize = paginatedResponse.PageSize,
            TotalPages = paginatedResponse.TotalPages
        });
    }
}