using Microsoft.EntityFrameworkCore;
using Reactions.Models;

namespace Reactions.Seeders;

public static class ItemTypeSeeder
{
    public static List<ItemTypeModel> Data = new()
    {
        new()
        {
            Id = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            Name = "Recipes"
        }
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemTypeModel>().HasData(Data);
    }
}