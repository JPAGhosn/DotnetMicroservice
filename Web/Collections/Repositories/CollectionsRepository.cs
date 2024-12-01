using Collections.Data;
using Collections.Models;
using Microsoft.EntityFrameworkCore;

namespace Collections.Repositories;

public class CollectionsRepository(CollectionsDbContext context)
{
    public async Task<List<CollectionModel>> Get(Guid? tagId, CancellationToken cancellationToken = default)
    {
        var query = context.Collections.AsQueryable();

        if (tagId is not null)
            query = query
                .Include(collection => collection.Tags)
                .Where(collection => collection.Tags.Any(tag => tag.Id == tagId));

        return await query.ToListAsync(cancellationToken);
    }

    public async Task<CollectionModel?> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await context
            .Collections
            .Where(collection => collection.Id == id)
            .Include(collection => collection.Recipes)
            .FirstOrDefaultAsync(cancellationToken);
    }
}