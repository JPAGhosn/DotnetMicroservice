using Microsoft.EntityFrameworkCore;
using Reactions.Models;

namespace Reactions.Seeders;

public static class ItemsHasReactionsSeeder
{
    public static List<ItemHasReaction> Data = new()
    {
        // Likes
        // Recipe: Basic Sabzee (Curried Vegetables)
        new ItemHasReaction
        {
            ItemId = Guid.Parse("9ecd7941-eafd-4b6a-b129-f3808c3d9bfc"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("9ecd7941-eafd-4b6a-b129-f3808c3d9bfc"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("6b7ffda1-eaab-43bd-b61d-bf0d35766590")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("9ecd7941-eafd-4b6a-b129-f3808c3d9bfc"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("f15ee0e3-ee98-474f-b08d-a96d42b76dc4")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("9ecd7941-eafd-4b6a-b129-f3808c3d9bfc"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("18590908-6512-4948-95ca-14ebb9b75652")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("9ecd7941-eafd-4b6a-b129-f3808c3d9bfc"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("ebf82549-cfeb-4f3f-a753-21dfcc0ccb61")
        },

        // Dislikes
        // Recipe: Basic Sabzee (Curried Vegetables)
        new ItemHasReaction
        {
            ItemId = Guid.Parse("9ecd7941-eafd-4b6a-b129-f3808c3d9bfc"),
            ReactionId = Guid.Parse("e67ac662-033b-4927-8315-7b044a4ee1ba"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("bd0f2bb7-001b-4990-a15d-48959bfd66dc")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("9ecd7941-eafd-4b6a-b129-f3808c3d9bfc"),
            ReactionId = Guid.Parse("e67ac662-033b-4927-8315-7b044a4ee1ba"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("9bbbd1a5-6e07-4e82-998a-7376b3d65909")
        },

        // Likes
        // Recipe: Mango Lassi
        new ItemHasReaction
        {
            ItemId = Guid.Parse("7f407a72-ba91-4851-9c59-ceeb069b8454"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("7f407a72-ba91-4851-9c59-ceeb069b8454"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("6b7ffda1-eaab-43bd-b61d-bf0d35766590")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("7f407a72-ba91-4851-9c59-ceeb069b8454"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("f15ee0e3-ee98-474f-b08d-a96d42b76dc4")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("7f407a72-ba91-4851-9c59-ceeb069b8454"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("18590908-6512-4948-95ca-14ebb9b75652")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("7f407a72-ba91-4851-9c59-ceeb069b8454"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("ebf82549-cfeb-4f3f-a753-21dfcc0ccb61")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("7f407a72-ba91-4851-9c59-ceeb069b8454"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("bd0f2bb7-001b-4990-a15d-48959bfd66dc")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("7f407a72-ba91-4851-9c59-ceeb069b8454"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("9bbbd1a5-6e07-4e82-998a-7376b3d65909")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("7f407a72-ba91-4851-9c59-ceeb069b8454"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("0fe05ee0-1254-4217-ad9b-9b8c8ba2bf46")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("7f407a72-ba91-4851-9c59-ceeb069b8454"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("9952a929-6005-4e2f-860c-f0e018dbcd89")
        },
        new ItemHasReaction
        {
            ItemId = Guid.Parse("7f407a72-ba91-4851-9c59-ceeb069b8454"),
            ReactionId = Guid.Parse("5333a2fe-3273-4c85-83eb-c20a7c225ec3"),
            ItemTypeId = Guid.Parse("98ee5307-f584-4951-8acf-3c60bfda550b"),
            ProfileId = Guid.Parse("0ec74399-11e5-4d26-b21c-8666caa884a7")
        }
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemHasReaction>().HasData(Data);
    }
}