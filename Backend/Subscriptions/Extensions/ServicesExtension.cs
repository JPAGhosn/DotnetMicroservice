using KRK_Subscriptions.Client.Grpc;

namespace KRK_Subscriptions.Extensions;

public static class ServicesExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<ProfileDataClient>();
    }
}