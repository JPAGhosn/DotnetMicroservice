using Glimpses.Bindings;
using Glimpses.Clients.Grpc;
using Glimpses.Repositories;

namespace Glimpses.Endpoints;

public static class GlimpsesEndpoints
{
    public static void MapGlimpsesEndpoints(this WebApplication app)
    {
        app.MapGet("/api/glimpses", GetGlimpses);
    }

    private static async Task<IResult> GetGlimpses(GlimpsesRepository glimpsesRepository,
        ProfileDataClient profilesClient,
        PicturesBasePath picturesBasePath,
        CancellationToken cancellationToken)
    {
        var glimpses = await glimpsesRepository.GetAll(cancellationToken);

        var creatorsIds = glimpses.Select(recipe => recipe.CreatorId).Distinct().ToList();
        var profiles = await profilesClient.GetManyProfiles(creatorsIds, cancellationToken);

        glimpses = glimpses.Select(glimpse =>
        {
            var profile = profiles.FirstOrDefault(p => p.Id == glimpse.CreatorId);
            if (profile is not null) glimpse.Creator = profile;

            glimpse.VideoPath = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Glimpses + "/" + glimpse.VideoPath;
            glimpse.ThumbnailPath = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Glimpses + "/" +
                                    glimpse.ThumbnailPath;

            return glimpse;
        }).ToList();

        return Results.Ok(glimpses);
    }
}