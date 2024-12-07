using Collections.Repositories;
using Collections.Repositories.ElasticSearch;
using Collections.Services;
using Shared.Clients;
using Shared.Extensions;

namespace Collections.Extensions;

public static class ServicesExtension
{
    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSharedServices();

        services.AddScoped<CollectionsService>();
        services.AddScoped<CollectionsRepository>();

        services.AddScoped<RecipesRepository>();

        services.AddScoped<ProfileDataClient>();

        services.AddSingleton<CollectionElasticSearchRepository>();
    }
}