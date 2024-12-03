using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;

namespace Shared.Extensions;

public static class ElasticSearchExtension
{
    public static void SetupElasticSearch(this IServiceCollection services, IConfiguration configuration)
    {
        // Bind Elasticsearch settings from configuration
        var elasticsearchSettings = configuration.GetSection("Elasticsearch");
        var uri = new Uri(elasticsearchSettings["Uri"]!);
        var defaultIndex = elasticsearchSettings["DefaultIndex"];

        // Configure ConnectionSettings
        var connectionSettings = new ConnectionSettings(uri)
            .DefaultIndex(defaultIndex)
            .EnableDebugMode() // Optional: Enable for detailed logs
            .PrettyJson(); // Optional: Format JSON responses

        // If authentication is required
        var username = elasticsearchSettings["Username"];
        var password = elasticsearchSettings["Password"];
        if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            connectionSettings = connectionSettings.BasicAuthentication(username, password);

        // Register ElasticClient as a singleton
        services.AddSingleton<IElasticClient>(new ElasticClient(connectionSettings));
    }
}