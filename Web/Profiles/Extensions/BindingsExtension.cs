using KRK_Profiles.Bindings;
using Microsoft.Extensions.Options;

namespace KRK_Profiles.Extensions;

public static class BindingsExtension
{
    public static void AddBindings(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<PicturesBasePathBindings>(configuration.GetSection("PicturesBasePath"));
        services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<PicturesBasePathBindings>>().Value);
    }
}