using Microsoft.EntityFrameworkCore;
using Tags.Models;
using Tags.Seeders;

namespace Tags.Data;

public class TagsDbContext(DbContextOptions<TagsDbContext> options) : DbContext(options)
{
    public DbSet<TagModel> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();

        base.OnModelCreating(modelBuilder);
    }
}