using Glimpses.Data;
using Glimpses.Models;
using Microsoft.EntityFrameworkCore;

namespace Glimpses.Repositories;

public class GlimpsesRepository(GlimpseDbContext context)
{
    public async Task<List<GlimpseModel>> GetAll(CancellationToken cancellationToken)
    {
        return await context.Glimpses.ToListAsync(cancellationToken);
    }
}