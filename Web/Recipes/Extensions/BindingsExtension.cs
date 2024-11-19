using Microsoft.Extensions.Options;
using Recipes.Bindings;

namespace Recipes.Extensions;

public static class BindingsExtension
{
    public static void AddBindings(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<PicturesBasePath>(configuration.GetSection("PicturesBasePath"));
        services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<PicturesBasePath>>().Value);

        services.Configure<ProfilesServiceBinding>(configuration.GetSection("ProfilesService"));
        services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<ProfilesServiceBinding>>().Value);
    }
}