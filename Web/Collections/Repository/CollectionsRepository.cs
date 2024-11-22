using Collections.Data;
using Collections.Models;
using Microsoft.EntityFrameworkCore;

namespace Collections.Repository;

public class CollectionsRepository(CollectionsDbContext context)
{
    public async Task<List<CollectionModel>> Get()
    {
        return await context.Collections.ToListAsync();
    }
}