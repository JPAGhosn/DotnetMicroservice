using Microsoft.EntityFrameworkCore;
using Tags.Data;

namespace Tags.Extensions;

public static class DatabaseExtension
{
    public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TagsDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("TagsConnectionString"));
        });
    }
}