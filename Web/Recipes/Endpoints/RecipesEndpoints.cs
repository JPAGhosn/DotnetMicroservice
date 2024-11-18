using Recipes.Bindings;
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
        CancellationToken cancellationToken)
    {
        var recipes = await recipesRepository.GetAll(cancellationToken);
        recipes = recipes.Select(recipe =>
        {
            if (recipe.Cover is not null)
                recipe.Cover = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Recipes + "/" + recipe.Cover;
            return recipe;
        }).ToList();

        return Results.Ok(recipes);
    }
}