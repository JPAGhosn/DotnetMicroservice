using Glimpses.Bindings;
using Microsoft.Extensions.Options;

namespace Glimpses.Extensions;

public static class BindingsExtension
{
    public static void AddBindings(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<ProfilesServiceBinding>(configuration.GetSection("ProfilesService"));
        services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<ProfilesServiceBinding>>().Value);

        services.Configure<PicturesBasePath>(configuration.GetSection("PicturesBasePath"));
        services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<PicturesBasePath>>().Value);
    }
}