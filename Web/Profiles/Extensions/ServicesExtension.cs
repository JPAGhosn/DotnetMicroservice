using KRK_Profiles.Repositories;
using KRK_Profiles.Services.Grpc;

namespace KRK_Profiles.Extensions;

public static class ServicesExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<GrpcProfileService>();
        services.AddScoped<ProfileRepository>();
    }
}