using Microsoft.EntityFrameworkCore;
using Profiles.Data;

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