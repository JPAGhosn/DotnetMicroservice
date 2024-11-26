using Reactions.Repositories;

namespace Reactions.Extensions;

public static class RepositoriesExtension
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ReactionsRepository>();
    }
}