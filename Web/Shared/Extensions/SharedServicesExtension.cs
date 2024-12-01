using Microsoft.Extensions.DependencyInjection;
using Shared.Bindings;
using Shared.Clients;

namespace Shared.Extensions;

public static class SharedServicesExtension
{
    public static void AddSharedServices(this IServiceCollection services)
    {
        services.AddScoped<ProfileDataClient>();
        services.AddScoped<ProfilesServiceBinding>();
    }
}