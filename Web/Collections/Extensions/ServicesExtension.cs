using Collections.Clients.Grpc;
using Collections.Repository;

namespace Collections.Extensions;

public static class ServicesExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<CollectionsRepository>();
        services.AddScoped<ProfileDataClient>();
    }
}