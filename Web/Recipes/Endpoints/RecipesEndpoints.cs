using KRK_Shared.Models;
using Recipes.Dtos.Recipe;
using Recipes.Models;
using Recipes.Repositories;
using Shared.Bindings;
using Shared.Clients;

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
        var recipe = await recipesRepository.GetById(recipeId, cancellationToken);
        if (recipe is null) return Results.NotFound();

        HydrateRecipeCoverImage(ref recipe, picturesBasePath);

        var recipeDto = new RecipeReadDto(recipe);

        recipeDto.Creator = await profilesClient.GetOne(recipe.CreatorId, cancellationToken);


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
                HydrateRecipeCoverImage(ref recipe, picturesBasePath);
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

    private static void HydrateRecipeCoverImage(ref RecipeModel recipe, PicturesBasePath picturesBasePath)
    {
        recipe.Cover = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Recipes + "/" + recipe.Cover;
    }
}