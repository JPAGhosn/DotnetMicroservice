using KRK_Subscriptions.Client.Grpc;
using KRK_Subscriptions.Data;
using Microsoft.EntityFrameworkCore;

namespace KRK_Subscriptions.Endpoints;

public static class SubscriptionsEndpoint
{
    public static void MapSubscriptionsEndpoints(this WebApplication app)
    {
        app
            .MapGet("/subscriptions", GetSubscriptions)
            .WithName("GetSubscriptions")
            .WithOpenApi();
    }

    private static async Task<IResult> GetSubscriptions(
        SubscriptionsDbContext dbContext,
        ProfileDataClient profileDataClient,
        CancellationToken cancellationToken)
    {
        var subscriptions = await dbContext.Subscriptions.ToListAsync(cancellationToken);

        // Hydrate profile
        var profileIds = subscriptions.Select(s => s.ProfileId).Distinct().ToList();
        var profiles = await profileDataClient.GetManyProfiles(profileIds);

        foreach (var profile in profiles) subscriptions.First(s => s.ProfileId == profile.Id).Profile = profile;

        return Results.Ok(subscriptions);
    }
}