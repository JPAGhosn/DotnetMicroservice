using Glimpses.Bindings;
using Glimpses.Clients.Grpc;
using Glimpses.Dtos;
using Glimpses.Repositories;

namespace Glimpses.Endpoints;

public static class GlimpsesEndpoints
{
    public static void MapGlimpsesEndpoints(this WebApplication app)
    {
        app.MapGet("/api/glimpses", GetGlimpses);
    }

    private static async Task<IResult> GetGlimpses(
        Guid? tagId,
        GlimpsesRepository glimpsesRepository,
        ProfileDataClient profilesClient,
        PicturesBasePath picturesBasePath,
        CancellationToken cancellationToken)
    {
        var glimpses = await glimpsesRepository.GetAll(
            tagId,
            cancellationToken
        );

        var creatorsIds = glimpses.Select(recipe => recipe.CreatorId).Distinct().ToList();
        var profiles = await profilesClient.GetManyProfiles(creatorsIds, cancellationToken);

        // Convert to Dto to prevent cycle and process path to url.
        var glimpsesDto = glimpses.Select(glimpse =>
        {
            var profile = profiles.FirstOrDefault(p => p.Id == glimpse.CreatorId);
            if (profile is not null) glimpse.Creator = profile;

            glimpse.VideoPath = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Glimpses + "/" + glimpse.VideoPath;
            glimpse.ThumbnailPath = picturesBasePath.SeaweedFS + "/" + picturesBasePath.Glimpses + "/" +
                                    glimpse.ThumbnailPath;

            return new GlimpseViewDto(glimpse);
        }).ToList();


        return Results.Ok(glimpsesDto);
    }
}