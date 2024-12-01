using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Shared.Bindings;

namespace Shared.Extensions;

public static class BindingsExtension
{
    public static void AddSharedBindings(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<ProfilesServiceBinding>(configuration.GetSection("ProfilesService"));
        services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<ProfilesServiceBinding>>().Value);

        services.Configure<PicturesBasePath>(configuration.GetSection("PicturesBasePath"));
        services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<PicturesBasePath>>().Value);
    }
}