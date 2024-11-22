using Collections.Models;
using Collections.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Collections.Data;

public class CollectionsDbContext(DbContextOptions<CollectionsDbContext> options) : DbContext(options)
{
    public DbSet<CollectionModel> Collections { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        CollectionsSeeder.Seed(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }
}