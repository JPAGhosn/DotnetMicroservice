using Reactions.Repositories;
using Reactions.Responses;

namespace Reactions.Endpoints;

public static class ReactionsEndpoints
{
    public static void MapReactionsEndpoints(this WebApplication app)
    {
        app.MapGet("/api/reactions/reactions-counts/{itemId}", GetReactionsCounts);
    }

    private static async Task<IResult> GetReactionsCounts(
        HttpContext context,
        Guid itemId,
        ReactionsRepository reactionsRepository,
        CancellationToken cancellationToken)
    {
        var likesCount = await reactionsRepository.GetLikesCountByItemId(itemId, cancellationToken);
        var dislikesCount = await reactionsRepository.GetDislikesCountByItemId(itemId, cancellationToken);

        var response = new GetReactionsResponse
        {
            LikesCount = likesCount,
            DislikesCount = dislikesCount
        };

        return Results.Ok(response);
    }
}