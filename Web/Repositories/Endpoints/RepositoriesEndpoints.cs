using Newtonsoft.Json;
using Repositories.Bindings;
using Repositories.Models;
using Repositories.Services;

namespace Repositories.Endpoints;

public static class RepositoriesEndpoints
{
    public static void MapRepositoriesEndpoints(this WebApplication app)
    {
        app.MapGet("/api/repositories/{repositoryId}/{branchName}", GetRecipesInformation);
    }

    private static async Task<IResult> GetRecipesInformation(Guid repositoryId, string branchName,
        RepositoriesServiceBinding serviceBinding,
        RepositoriesService repositoriesService,
        CancellationToken cancellationToken)
    {
        var tasks = new[]
        {
            repositoriesService.GetFileContent(repositoryId, branchName, "index.json",
                cancellationToken),
            repositoriesService.GetFileContent(repositoryId, branchName, "index.md", cancellationToken),
            repositoriesService.GetFileContent(repositoryId, branchName, "instructions.json",
                cancellationToken),
            repositoriesService.GetFileContent(repositoryId, branchName, "license.md",
                cancellationToken),
            repositoriesService.GetFileContent(repositoryId, branchName, "code-of-conduct.md",
                cancellationToken)
        };

        var results = await Task.WhenAll(tasks);

        var indexJson = JsonConvert.DeserializeObject<IndexJsonModel>(results[0]);
        var indexMd = results[1];
        var instructions = JsonConvert.DeserializeObject<dynamic>(results[2]);
        var license = results[3];
        var codeOfConduct = results[4];

        return Results.Ok(new
        {
            Index = indexJson,
            IndexMd = indexMd,
            Instructions = instructions,
            License = license,
            CodeOfConduct = codeOfConduct
        });
    }
}