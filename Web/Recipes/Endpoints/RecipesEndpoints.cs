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
    }

    private static async Task<IResult> GetRecipes(RecipesRepository recipesRepository,
        PicturesBasePath picturesBasePath,
        ProfileDataClient profilesClient,
        CancellationToken cancellationToken)
    {
        var recipes = await recipesRepository.GetAll(cancellationToken);
        recipes = recipes.Select(recipe =>
        {
            if (recipe.Cover is not null)
                recipe.Cover = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Recipes + "/" + recipe.Cover;
            return recipe;
        }).ToList();

        var creatorsIds = recipes.Select(recipe => recipe.CreatorId).Distinct().ToList();

        var profiles = await profilesClient.GetManyProfiles(creatorsIds, cancellationToken);

        recipes = recipes.Select(recipe =>
        {
            var profile = profiles.FirstOrDefault(p => p.Id == recipe.CreatorId);
            if (profile is not null)
            {
                recipe.Creator = profile;
            }
            return recipe;
        }).ToList();

        var recipesDtos = recipes.Select(recipe => new RecipeViewDto(recipe)).ToList();

        return Results.Ok(recipesDtos);
    }
}