using Repositories.Services;

namespace Repositories.Extensions;

public static class ServicesExtension
{
    public static void SetupServices(this IServiceCollection services)
    {
        services.AddScoped<RepositoriesService>();
    }
}