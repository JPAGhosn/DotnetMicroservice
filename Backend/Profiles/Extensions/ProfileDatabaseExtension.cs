using KRK_Profiles.Data;
using Microsoft.EntityFrameworkCore;

namespace KRK_Profiles.Extensions;

public static class ProfileDatabaseExtension
{
    public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ProfilesDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("ProfilesConnectionString"));
        });
    }
}