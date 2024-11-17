using KRK_Subscriptions.Client.Grpc;
using KRK_Subscriptions.Data;
using KRK_Subscriptions.Models;
using Microsoft.EntityFrameworkCore;

namespace KRK_Subscriptions.Endpoints;

public static class SubscriptionsEndpoint
{
    public static void MapSubscriptionsEndpoints(this WebApplication app)
    {
        app
            .MapGet("/api/subscriptions", GetSubscriptions)
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

        var subsResponse = new List<SubscriptionModel>();

        foreach (var profile in profiles)
        {
            var sub = subscriptions.FirstOrDefault(s => s.ProfileId == profile.Id);
            if (sub is null) continue;
            sub.FirstName = profile.FirstName;
            sub.LastName = profile.LastName;
            sub.UserName = profile.UserName;
            sub.ProfilePicture = profile.ProfilePicture;
            sub.CoverPicture = profile.CoverPicture;
            subsResponse.Add(sub);
        }

        return Results.Ok(subsResponse);
    }
}