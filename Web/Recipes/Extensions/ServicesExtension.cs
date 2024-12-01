using Recipes.Repositories;
using Shared.Extensions;

namespace Recipes.Extensions;

public static class ServicesExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<RecipesRepository>();
        services.AddSharedServices();
    }
}