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

        CollectionsSeeder.Seed(modelBuilder);
        RecipesSeeder.Seed(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }
}