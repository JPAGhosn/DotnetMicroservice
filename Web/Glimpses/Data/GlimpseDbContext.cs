using Glimpses.Models;
using Glimpses.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Glimpses.Data;

public class GlimpseDbContext(DbContextOptions<GlimpseDbContext> options) : DbContext(options)
{
    public DbSet<GlimpseModel> Glimpses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        GlimpsesSeeder.Seed(modelBuilder);


        base.OnModelCreating(modelBuilder);
    }
}