using KRK_Profiles.Services.Grpc;

namespace KRK_Profiles.Extensions;

public static class GrpcExtension
{
    public static void AddKrkGrpc(this IServiceCollection services)
    {
        services.AddGrpc();
    }

    public static void MapKrkGrpc(this WebApplication app)
    {
        app.MapGrpcService<GrpcProfileService>();
    }
}