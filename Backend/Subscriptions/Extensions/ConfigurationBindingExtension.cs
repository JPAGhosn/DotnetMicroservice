using KRK_Subscriptions.Configurations;
using Microsoft.Extensions.Options;

namespace KRK_Subscriptions.Extensions;

public static class ConfigurationBindingExtension
{
    public static void AddConfigurationSettings(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<ProfilesServiceConfiguration>(configuration.GetSection("ProfilesService"));
        services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<ProfilesServiceConfiguration>>().Value);
    }
}