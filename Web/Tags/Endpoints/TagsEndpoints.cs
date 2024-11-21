using Tags.Repositories;

namespace Tags.Endpoints;

public static class TagsEndpoints
{
    public static void MapTagsEndpoints(this WebApplication app)
    {
        app.MapGet("/api/tags", GetTags);
    }

    private static async Task<IResult> GetTags(TagsRepository tagsRepository, CancellationToken cancellationToken)
    {
        var tags = await tagsRepository.GetAllTags();
        return Results.Ok(tags);
    }
}