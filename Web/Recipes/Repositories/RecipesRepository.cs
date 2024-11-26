using KRK_Shared.Helpers;
using KRK_Shared.Models;
using Microsoft.EntityFrameworkCore;
using Recipes.Data;
using Recipes.Models;

namespace Recipes.Repositories;

public class RecipesRepository(RecipesDbContext context)
{
    public async Task<PaginationResponse<RecipeModel>> GetAll(
        int pageNumber,
        int pageSize,
        Guid? tagId,
        CancellationToken cancellationToken
    )
    {
        var query = context.Recipes
            .Include(recipe => recipe.Tags)
            .AsQueryable();

        if (tagId.HasValue)
            query = query.Where(recipe => recipe.Tags.Any(tag => tag.Id == tagId.Value));

        return await PaginationHelper.Pagination(query, pageNumber, pageSize, cancellationToken);
    }

    public async Task<RecipeModel?> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await context.Recipes
            .FirstOrDefaultAsync(recipe => recipe.Id == id, cancellationToken);
    }
}