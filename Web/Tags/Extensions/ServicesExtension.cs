using Tags.Repositories;

namespace Tags.Extensions;

public static class ServicesExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<TagsRepository>();
    }
}