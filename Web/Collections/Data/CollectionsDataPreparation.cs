using Collections.Models.ElasticSearch;
using Collections.Repositories.ElasticSearch;
using Collections.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Collections.Data;

public static class CollectionsDataPreparation
{
    public static async Task GenerateData(IApplicationBuilder app, bool isProd)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        await SeedData(app, serviceScope.ServiceProvider.GetService<CollectionsDbContext>()!, isProd);
    }

    private static async Task GenerateElasticData(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        var collectionsElasticSearchRepository =
            serviceScope.ServiceProvider.GetService<CollectionElasticSearchRepository>()!;

        try
        {
            await collectionsElasticSearchRepository.DeleteAllDocumentsAsync();
            await collectionsElasticSearchRepository.DeleteIndexAsync();
        }
        catch (Exception e)
        {
        }

        await collectionsElasticSearchRepository
            .CreateIndexIfNotExistsAsync();

        await collectionsElasticSearchRepository.BulkIndexCollectionsAsync(
            CollectionsSeeder.Data.Select(collection => new CollectionEksModel
            {
                Id = collection.Id,
                Name = collection.Name,
                CreatorId = collection.CreatorId
            }));
    }

    private static async Task SeedData(IApplicationBuilder app, CollectionsDbContext context, bool isProd)
    {
        // await GenerateElasticData(app);

        if (isProd)
            try
            {
                Console.WriteLine("Building the database...");
                await context.Database.MigrateAsync();
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