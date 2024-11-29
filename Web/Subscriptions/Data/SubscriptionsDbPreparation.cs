using KRK_Subscriptions.Seeders;
using Microsoft.EntityFrameworkCore;
using Subscriptions.Data;

namespace KRK_Subscriptions.Data;

public static class SubscriptionsDbPreparation
{
    public static void PrepPopulation(IApplicationBuilder app, bool isProd)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            SeedData(serviceScope.ServiceProvider.GetService<SubscriptionsDbContext>()!, isProd);
        }
    }

    private static void SeedData(SubscriptionsDbContext context, bool isProd)
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

        if (!context.Subscriptions.Any())
        {
            Console.WriteLine("--> Seeding Data...");

            foreach (var subscription in SubscriptionsSeeder.Subscriptions)
                context.Subscriptions.Add(subscription);

            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("--> We already have data");
        }
    }
}