using Microsoft.EntityFrameworkCore;

namespace KRK_Profiles.Data;

public static class ProfilesDbPreparation
{
    public static void PrepPopulation(IApplicationBuilder app, bool isProd)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            SeedData(serviceScope.ServiceProvider.GetService<ProfilesDbContext>(), isProd);
        }
    }

    private static void SeedData(ProfilesDbContext context, bool isProd)
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

        if (!context.Profiles.Any())
        {
            Console.WriteLine("--> Seeding Data...");

            // Here add your seeders (only seeders needed)

            // context.Profiles.AddRange(
            //     new Platform { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
            //     new Platform { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" },
            //     new Platform { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }
            // );

            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("--> We already have data");
        }
    }
}