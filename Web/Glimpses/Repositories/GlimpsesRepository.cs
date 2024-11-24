using Glimpses.Data;
using Glimpses.Models;
using Microsoft.EntityFrameworkCore;

namespace Glimpses.Repositories;

public class GlimpsesRepository(GlimpsesDbContext context)
{
    public async Task<List<GlimpseModel>> GetAll(Guid? tagId, CancellationToken cancellationToken)
    {
        var query = context.Glimpses.AsQueryable();

        if (tagId != null)
            query = query
                .Include(glimpse => glimpse.Tags)
                .Where(glimpse => glimpse.Tags.Any(t => t.Id == tagId));

        return await query.ToListAsync(cancellationToken);
    }
}