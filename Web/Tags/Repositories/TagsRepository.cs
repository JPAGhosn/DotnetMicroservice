using Microsoft.EntityFrameworkCore;
using Tags.Data;
using Tags.Models;

namespace Tags.Repositories;

public class TagsRepository(TagsDbContext context)
{
    public async Task<List<TagModel>> GetAllTags()
    {
        return await context.Tags.ToListAsync();
    }
}