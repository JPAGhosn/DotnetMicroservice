using Collections.Data;
using Collections.Models;
using Collections.Repositories;
using Microsoft.EntityFrameworkCore;
using Shared.Exceptions;

namespace Collections.Services;

public class CollectionsService(
    CollectionsRepository collectionsRepository,
    CollectionsDbContext context
)
{
    public async Task<bool> AddRecipe(
        Guid userId,
        Guid collectionId,
        Guid recipeId,
        CancellationToken cancellationToken
    )
    {
        // Check if collection exists and current user is the one who created
        var collection = await collectionsRepository.GetById(collectionId, cancellationToken);
        if (collection == null) throw new NotFoundException("Collection Not Found", "Collection not found");
        if (collection.CreatorId != userId)
            throw new UnauthorizedException("Unauthorized Access", "You are not authorized to perform this action");

        // check if recipe exists
        var recipe = await context.Recipes.Where(recipe => recipe.ExternalId == recipeId)
            .FirstOrDefaultAsync(cancellationToken);

        // If the recipe is null, add a new reference in the collections database
        if (recipe is null)
        {
            recipe = new RecipeModel
            {
                Id = recipeId,
                ExternalId = recipeId
            };

            await context.Recipes.AddAsync(recipe, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        // Add the recipe to the collection
        // This won't throw any error if the recipe is already added. It won't adding it again.
        collection.Recipes.Add(recipe);
        await context.SaveChangesAsync(cancellationToken);

        return true;
    }
}