using KRK_Subscriptions.Data;
using Microsoft.EntityFrameworkCore;
using Subscriptions.Data;

namespace KRK_Subscriptions.Extensions;

public static class DatabaseExtension
{
    public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<SubscriptionsDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("SubscriptionsConnectionString"));
        });
    }
}