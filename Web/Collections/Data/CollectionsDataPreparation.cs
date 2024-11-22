using Collections.Data;
using Collections.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Glimpses.Data;

public static class CollectionsDataPreparation
{
    public static void GenerateData(IApplicationBuilder app, bool isProd)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        SeedData(serviceScope.ServiceProvider.GetService<CollectionsDbContext>()!, isProd);
    }

    private static void SeedData(CollectionsDbContext context, bool isProd)
    {
        if (isProd)
            try
            {
                Console.WriteLine("Building the database...");
                context.Database.Migrate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        if (!context.Collections.Any())
        {
            Console.WriteLine("Seeding recipes...");
            foreach (var glimpse in CollectionsSeeder.Data)
                context.Collections.Add(glimpse);

            context.SaveChanges();
        }
    }
}