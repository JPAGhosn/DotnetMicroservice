using Glimpses.Repositories;

namespace Glimpses.Endpoints;

public static class GlimpsesEndpoints
{
    public static void MapGlimpsesEndpoints(this WebApplication app)
    {
        app.MapGet("/api/glimpses", GetGlimpses);
    }

    public static async Task<IResult> GetGlimpses(GlimpsesRepository glimpsesRepository,
        CancellationToken cancellationToken)
    {
        var response = await glimpsesRepository.GetAll(cancellationToken);
        return Results.Ok(response);
    }
}