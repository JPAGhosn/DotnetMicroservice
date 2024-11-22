using Collections.Data;
using Microsoft.EntityFrameworkCore;

namespace Collections.Extensions;

public static class DatabaseExtension
{
    public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CollectionsDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("CollectionsConnectionString"));
        });
    }
}