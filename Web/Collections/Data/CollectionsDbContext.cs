using Collections.Models;
using Collections.ModelsConfiguration;
using Collections.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Collections.Data;

public class CollectionsDbContext(DbContextOptions<CollectionsDbContext> options) : DbContext(options)
{
    public DbSet<CollectionModel> Collections { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CollectionModelConfiguration());

        TagsSeeder.Seed(modelBuilder);
        CollectionsSeeder.Seed(modelBuilder);
        RecipesSeeder.Seed(modelBuilder);
        CollectionHasRecipeSeeder.Seed(modelBuilder);
        CollectionHasTagSeeder.Seed(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }
}