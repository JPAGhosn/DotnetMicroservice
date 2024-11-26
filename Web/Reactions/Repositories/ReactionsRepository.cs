using Microsoft.EntityFrameworkCore;
using Reactions.Data;

namespace Reactions.Repositories;

public class ReactionsRepository(ReactionsDbContext context)
{
    public async Task<ulong> GetLikesCountByItemId(Guid itemId, CancellationToken cancellationToken)
    {
        return await context.ItemHasReactionCounts
            .Include(reaction => reaction.Reaction)
            .Where(reaction => reaction.Reaction.Name == "Like" && reaction.ItemId == itemId)
            .Select(itemsHasReactionsSeeder => itemsHasReactionsSeeder.Count)
            .FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<ulong> GetDislikesCountByItemId(Guid itemId, CancellationToken cancellationToken)
    {
        return await context.ItemHasReactionCounts
            .Include(reaction => reaction.Reaction)
            .Where(reaction => reaction.Reaction.Name == "Dislike" && reaction.ItemId == itemId)
            .Select(itemsHasReactionsSeeder => itemsHasReactionsSeeder.Count)
            .FirstOrDefaultAsync(cancellationToken);
    }
}