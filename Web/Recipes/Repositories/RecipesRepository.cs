using Microsoft.EntityFrameworkCore;
using Recipes.Data;
using Recipes.Models;

namespace Recipes.Repositories;

public class RecipesRepository(RecipesDbContext context)
{
    public async Task<List<RecipeModel>> GetAll(CancellationToken cancellationToken)
    {
        return await context.Recipes.ToListAsync(cancellationToken);
    }
}