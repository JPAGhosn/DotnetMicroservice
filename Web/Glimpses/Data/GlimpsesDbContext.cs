using Glimpses.Models;
using Glimpses.ModelsConfiguration;
using Glimpses.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Glimpses.Data;

public class GlimpsesDbContext(DbContextOptions<GlimpsesDbContext> options) : DbContext(options)
{
    public DbSet<GlimpseModel> Glimpses { get; set; }
    public DbSet<TagModel> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new GlimpseModelConfiguration());

        GlimpsesSeeder.Seed(modelBuilder);
        TagsSeeder.Seed(modelBuilder);
        GlimpseHasTagSeeder.Seed(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }
}