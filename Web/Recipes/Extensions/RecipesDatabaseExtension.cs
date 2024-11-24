using Microsoft.EntityFrameworkCore;
using Recipes.Data;

namespace Recipes.Extensions;

public static class RecipesDatabaseExtension
{
    public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RecipesDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("RecipesConnectionString"));
            options.EnableDetailedErrors();
            options.EnableSensitiveDataLogging();
        });
    }
}