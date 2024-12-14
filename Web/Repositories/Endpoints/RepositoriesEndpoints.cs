using KRK_Shared.Helpers;
using Newtonsoft.Json;
using Repositories.Bindings;
using Repositories.Models;
using Repositories.Payload;
using Repositories.Services;
using Shared.Bindings;

namespace Repositories.Endpoints;

public static class RepositoriesEndpoints
{
    public static void MapRepositoriesEndpoints(this WebApplication app)
    {
        app.MapGet("/api/repositories/{recipeId}/{branchName}", GetRecipesInformation);
        app.MapPost("/api/repositories/{recipeId}/{branchName}", UpdateFile);
    }

    private static async Task<IResult> UpdateFile(Guid recipeId, string branchName, UpdateFilePayload payload,
        RepositoriesService repositoriesService, CancellationToken cancellationToken)
    {
        await repositoriesService.UpdateFileContent(recipeId, branchName, payload, cancellationToken);
        return Results.Ok();
    }

    private static async Task<IResult> GetRecipesInformation(Guid recipeId, string branchName,
        RepositoriesServiceBinding serviceBinding,
        RepositoriesService repositoriesService,
        ImageHydrationHelper imageHydrationHelper,
        PicturesBasePath picturesBasePath,
        CancellationToken cancellationToken)
    {
        var tasks = new[]
        {
            repositoriesService.GetFileContent(recipeId, branchName, "index.json",
                cancellationToken),
            repositoriesService.GetFileContent(recipeId, branchName, "index.md", cancellationToken),
            repositoriesService.GetFileContent(recipeId, branchName, "instructions.json",
                cancellationToken),
            repositoriesService.GetFileContent(recipeId, branchName, "license.md",
                cancellationToken),
            repositoriesService.GetFileContent(recipeId, branchName, "code-of-conduct.md",
                cancellationToken)
        };

        var results = await Task.WhenAll(tasks);

        var indexJson = JsonConvert.DeserializeObject<IndexJsonModel>(results[0])!;
        indexJson.Recipe.Cover = imageHydrationHelper.HydrateImage(picturesBasePath.Recipes, indexJson.Recipe.Cover);

        var indexMd = results[1];
        var instructions = JsonConvert.DeserializeObject<dynamic>(results[2])!;
        var license = results[3];
        var codeOfConduct = results[4];

        return Results.Ok(new RepositoryModel
        {
            Id = recipeId,
            Index = indexJson,
            IndexMd = indexMd,
            Instructions = instructions,
            License = license,
            CodeOfConduct = codeOfConduct
        });
    }
}