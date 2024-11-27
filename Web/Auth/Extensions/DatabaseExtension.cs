using Auth.Data;
using KRK_Auth.Data;
using Microsoft.EntityFrameworkCore;

namespace KRK_Auth.Extensions;

public static class DatabaseExtension
{
    public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AuthDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("AuthConnectionString"));
        });
    }
}