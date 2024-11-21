using Glimpses.Repositories;

namespace Glimpses.Extensions;

public static class ServicesExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<GlimpsesRepository>();
    }
}