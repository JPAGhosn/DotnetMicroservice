using Microsoft.EntityFrameworkCore;
using Recipes.Seeders;

namespace Recipes.Data;

public class RecipesDataPreparation
{
    public static void GenerateData(IApplicationBuilder app, bool isProd)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        SeedData(serviceScope.ServiceProvider.GetService<RecipesDbContext>()!, isProd);
    }

    private static void SeedData(RecipesDbContext context, bool isProd)
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

        if (!context.Recipes.Any())
        {
            Console.WriteLine("Seeding recipes...");
            foreach (var profile in RecipesSeeder.Recipes)
                context.Recipes.Add(profile);

            context.SaveChanges();
        }
    }
}