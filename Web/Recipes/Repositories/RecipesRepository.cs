using Microsoft.EntityFrameworkCore;
using Recipes.Data;
using Recipes.Models;

namespace Recipes.Repositories;

public class RecipesRepository(RecipesDbContext context)
{
    public async Task<List<RecipeModel>> GetAll(
        int pageNumber,
        int pageSize,
        Guid? tagId,
        CancellationToken cancellationToken
    )
    {
        var query = context.Recipes
            .Include(recipe => recipe.Tags)
            .AsQueryable();

        if (tagId.HasValue) query = query.Where(recipe => recipe.Tags.Any(tag => tag.Id == tagId.Value));

        return await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
    }
}