using Microsoft.EntityFrameworkCore;
using Tags.Seeders;

namespace Tags.Data;

public static class TagsDbPreparation
{
    public static void PrepPopulation(IApplicationBuilder app, bool isProd)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            SeedData(serviceScope.ServiceProvider.GetService<TagsDbContext>()!, isProd);
        }
    }

    private static void SeedData(TagsDbContext context, bool isProd)
    {
        if (isProd)
        {
            Console.WriteLine("--> Attempting to apply migrations...");
            try
            {
                context.Database.Migrate();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"--> Could not run migrations: {ex.Message}");
            }
        }

        if (!context.Tags.Any())
        {
            Console.WriteLine("--> Seeding Data...");

            foreach (var subscription in TagsSeeder.data)
                context.Tags.Add(subscription);

            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("--> We already have data");
        }
    }
}