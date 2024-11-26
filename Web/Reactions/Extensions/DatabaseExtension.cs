using Microsoft.EntityFrameworkCore;
using Reactions.Data;

namespace Reactions.Extensions;

public static class DatabaseExtension
{
    public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ReactionsDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("ReactionsConnectionString"));
                options.EnableDetailedErrors();
                options.EnableSensitiveDataLogging();
            }
        );
    }
}