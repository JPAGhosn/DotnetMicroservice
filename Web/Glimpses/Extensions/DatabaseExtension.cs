using Glimpses.Data;
using Microsoft.EntityFrameworkCore;

namespace Glimpses.Extensions;

public static class DatabaseExtension
{
    public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<GlimpseDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("GlimpsesConnectionString"));
        });
    }
}