using Recipes.Repositories;

namespace Recipes.Extensions;

public static class ServicesExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<RecipesRepository>();
    }
}