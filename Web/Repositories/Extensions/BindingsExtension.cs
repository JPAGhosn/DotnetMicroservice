using Microsoft.Extensions.Options;
using Repositories.Bindings;

namespace Repositories.Extensions;

public static class BindingsExtension
{
    public static void AddBindings(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<RepositoriesServiceBinding>(configuration.GetSection("RepositoriesService"));
        services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<RepositoriesServiceBinding>>().Value);
    }
}