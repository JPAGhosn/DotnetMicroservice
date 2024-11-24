using Glimpses.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Glimpses.Data;

public static class GlimpsesDataPreparation
{
    public static void GenerateData(IApplicationBuilder app, bool isProd)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        SeedData(serviceScope.ServiceProvider.GetService<GlimpsesDbContext>()!, isProd);
    }

    private static void SeedData(GlimpsesDbContext context, bool isProd)
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

        if (!context.Glimpses.Any())
        {
            Console.WriteLine("Seeding recipes...");
            foreach (var glimpse in GlimpsesSeeder.Data)
                context.Glimpses.Add(glimpse);

            context.SaveChanges();
        }
    }
}