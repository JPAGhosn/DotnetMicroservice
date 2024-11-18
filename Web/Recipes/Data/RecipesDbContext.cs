using Microsoft.EntityFrameworkCore;
using Recipes.Models;
using Recipes.Seeders;

namespace Recipes.Data;

public class RecipesDbContext(DbContextOptions<RecipesDbContext> options) : DbContext(options)
{
    public DbSet<RecipeModel> Recipes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();

        base.OnModelCreating(modelBuilder);
    }
}