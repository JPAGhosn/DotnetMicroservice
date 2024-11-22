using Collections.Clients.Grpc;
using Collections.Repository;
using Glimpses.Bindings;

namespace Collections.Endpoints;

public static class CollectionsEndpoints
{
    public static void MapCollectionsEndpoints(this WebApplication app)
    {
        app.MapGet("/api/collections", GetCollections);
    }

    private static async Task<IResult> GetCollections(
        CollectionsRepository collectionsRepository,
        ProfileDataClient profileDataClient,
        PicturesBasePath picturesBasePath,
        CancellationToken cancellationToken)
    {
        var collections = await collectionsRepository.Get();

        var profilesIds = collections.Select(collection => collection.CreatorId).ToList();
        var profiles = await profileDataClient.GetManyProfiles(profilesIds, cancellationToken);

        foreach (var collection in collections)
        {
            var profile = profiles.FirstOrDefault(p => p.Id == collection.CreatorId);
            if (profile == null) continue;
            collection.Creator = profile;

            if (collection.CoverPath1 != null)
                collection.CoverPath1 = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Collections + "/" +
                                        collection.CoverPath1;

            if (collection.CoverPath2 != null)
                collection.CoverPath2 = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Collections + "/" +
                                        collection.CoverPath2;

            if (collection.CoverPath3 != null)
                collection.CoverPath3 = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Collections + "/" +
                                        collection.CoverPath3;
        }

        collections = collections.Where(collection => collection.Creator != null).ToList();

        return Results.Ok(collections);
    }
}