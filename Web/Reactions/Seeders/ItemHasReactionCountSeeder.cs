using Microsoft.EntityFrameworkCore;
using Reactions.Models;

namespace Reactions.Seeders;

public static class ItemHasReactionCountSeeder
{
    public static List<ItemHasReactionCount> Data = new()
    {
        new ItemHasReactionCount
        {
            ItemId = Guid.Parse("9ecd7941-eafd-4b6a-b129-f3808c3d9bfc"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            Count = 5
        },
        new ItemHasReactionCount
        {
            ItemId = Guid.Parse("9ecd7941-eafd-4b6a-b129-f3808c3d9bfc"),
            ReactionId = Guid.Parse("e67ac662-033b-4927-8315-7b044a4ee1ba"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            Count = 2
        },
        new ItemHasReactionCount
        {
            ItemId = Guid.Parse("7f407a72-ba91-4851-9c59-ceeb069b8454"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            Count = 10
        }
    };

    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<ItemHasReactionCount>().HasData(Data);
    }
}