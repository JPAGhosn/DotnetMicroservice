using Microsoft.EntityFrameworkCore;
using Reactions.Models;

namespace Reactions.Seeders;

public static class ReactionSeeder
{
    public static List<ReactionModel> Data { get; set; } = new()
    {
        new ReactionModel
        {
            Id = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            Name = "Like"
        },
        new ReactionModel
        {
            Id = Guid.Parse("e67ac662-033b-4927-8315-7b044a4ee1ba"),
            Name = "Dislike"
        }
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ReactionModel>().HasData(Data);
    }
}