using Microsoft.EntityFrameworkCore;
using Tags.Models;

namespace Tags.Seeders;

public static class TagsSeeder
{
    public static List<TagModel> data =
    [
        new()
        {
            Id = Guid.Parse("67fd736c-ac11-4c07-a8e8-7da245828866"),
            Name = "Asian"
        },
        new()
        {
            Id = Guid.Parse("8879ae6b-f7a5-4e3f-a433-d09856561e5a"),
            Name = "Noodles"
        },
        new()
        {
            Id = Guid.Parse("24f6b4cf-8f76-4d83-b79b-bd2e2f453845"),
            Name = "Italian"
        },
        new()
        {
            Id = Guid.Parse("9b1ac3fa-3f25-4ddf-8347-c5b3e534d512"),
            Name = "Pizza"
        },
        new()
        {
            Id = Guid.Parse("c2e0f6a7-d3a6-4b70-bd26-168cb5cfe5a8"),
            Name = "Burgers"
        },
        new()
        {
            Id = Guid.Parse("2d01fafa-f7c8-4b8b-9875-65c21b41a9a4"),
            Name = "Sushi"
        },
        new()
        {
            Id = Guid.Parse("ba8e8912-2f73-4fb4-94a5-15e35ad47e35"),
            Name = "Desserts"
        },
        new()
        {
            Id = Guid.Parse("0c6e579d-2eeb-488f-a807-7d8b0ea8f870"),
            Name = "Vegetarian"
        },
        new()
        {
            Id = Guid.Parse("1ea7d826-30e4-4c83-9ddc-feb3a9673c3b"),
            Name = "Seafood"
        },
        new()
        {
            Id = Guid.Parse("f2c9f40f-c9b0-4897-b29f-e4b5d27b85cc"),
            Name = "Mexican"
        },
        new()
        {
            Id = Guid.Parse("06f8ec91-f92b-4481-93de-5bb1ea8934f5"),
            Name = "BBQ"
        },
        new()
        {
            Id = Guid.Parse("ebd3be19-ff78-4269-8ef9-15b9efeb9499"),
            Name = "Steak"
        },
        new()
        {
            Id = Guid.Parse("12c5b73a-81c2-463b-858e-f09b4b81ff9c"),
            Name = "Indian"
        },
        new()
        {
            Id = Guid.Parse("5b5d7472-cb0a-401d-8a2f-27d3e9634973"),
            Name = "Mediterranean"
        },
        new()
        {
            Id = Guid.Parse("a7c5bd4f-50ae-4573-833f-b0ec1e8efc69"),
            Name = "Vegan"
        },
        new()
        {
            Id = Guid.Parse("781f1e8a-24a5-435c-a8cb-8d66b4d8495e"),
            Name = "Korean"
        },
        new()
        {
            Id = Guid.Parse("bc373c0b-3120-4d95-b2cb-8ec3f4a8e1d2"),
            Name = "Breakfast"
        },
        // Additional 50 entries with unique GUIDs
        new()
        {
            Id = Guid.Parse("3a7a92e4-9c1e-4c47-a9d0-1edc9bf81c6a"),
            Name = "Chinese"
        },
        new()
        {
            Id = Guid.Parse("5db8f7e9-39f2-4a7c-9a44-9f3df9d8060f"),
            Name = "Thai"
        },
        new()
        {
            Id = Guid.Parse("a1c0b32c-3c54-46b8-a99c-7b6a0a839028"),
            Name = "French"
        },
        new()
        {
            Id = Guid.Parse("6e99a3d8-2f16-4c29-bd11-0c8ed473a761"),
            Name = "Greek"
        },
        new()
        {
            Id = Guid.Parse("c14e4a3d-4efb-4b7d-94c3-9a0983e4b2d2"),
            Name = "Spanish"
        },
        new()
        {
            Id = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3"),
            Name = "Lebanese"
        },
        new()
        {
            Id = Guid.Parse("8fa3c275-f8b7-4c90-9910-6fefcd5bb1ae"),
            Name = "Turkish"
        },
        new()
        {
            Id = Guid.Parse("49c5e7e9-1b7f-4c41-9c8b-5e4e1fbb9d44"),
            Name = "German"
        },
        new()
        {
            Id = Guid.Parse("b2d0f3ab-8f52-4a63-8fdd-b0f7a6e89c3d"),
            Name = "Japanese"
        },
        new()
        {
            Id = Guid.Parse("d5c1cba7-0c76-4f9f-9d9a-3e4b5a6c7d8f"),
            Name = "Brazilian"
        },
        new()
        {
            Id = Guid.Parse("e6f0d2b9-1a3b-43c8-8b6a-1d2e3f4b5c6d"),
            Name = "Argentinian"
        },
        new()
        {
            Id = Guid.Parse("0a1b2c3d-4e5f-6789-abcd-ef0123456789"),
            Name = "African"
        },
        new()
        {
            Id = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef"),
            Name = "American"
        },
        new()
        {
            Id = Guid.Parse("2b3c4d5e-6f70-1234-5678-9abcdef01234"),
            Name = "Caribbean"
        },
        new()
        {
            Id = Guid.Parse("3c4d5e6f-7081-2345-6789-abcdef012345"),
            Name = "Fusion"
        },
        new()
        {
            Id = Guid.Parse("4d5e6f70-8192-3456-789a-bcdef0123456"),
            Name = "Gluten-Free"
        },
        new()
        {
            Id = Guid.Parse("5e6f7081-9234-4567-89ab-cdef01234567"),
            Name = "Halal"
        },
        new()
        {
            Id = Guid.Parse("6f708192-3456-5678-9abc-def012345678"),
            Name = "Kosher"
        },
        new()
        {
            Id = Guid.Parse("7f819203-4567-6789-abcd-ef0123456789"),
            Name = "Organic"
        },
        new()
        {
            Id = Guid.Parse("8f920314-5678-789a-bcde-f01234567890"),
            Name = "Raw"
        },
        new()
        {
            Id = Guid.Parse("9fa30425-6789-89ab-cdef-012345678901"),
            Name = "Soul Food"
        },
        new()
        {
            Id = Guid.Parse("a0b1c2d3-e4f5-6789-0abc-def012345678"),
            Name = "Street Food"
        },
        new()
        {
            Id = Guid.Parse("b1c2d3e4-f506-7890-abcd-ef0123456789"),
            Name = "Tapas"
        },
        new()
        {
            Id = Guid.Parse("c2d3e4f5-0617-890a-bcde-f01234567890"),
            Name = "Wine"
        },
        new()
        {
            Id = Guid.Parse("d3e4f506-1728-90ab-cdef-012345678901"),
            Name = "Craft Beer"
        },
        new()
        {
            Id = Guid.Parse("e4f50617-2839-0abc-def0-123456789012"),
            Name = "Cocktails"
        },
        new()
        {
            Id = Guid.Parse("f5061728-394a-1bcd-ef01-234567890123"),
            Name = "Pasta"
        },
        new()
        {
            Id = Guid.Parse("06172839-4a5b-2cde-f012-345678901234"),
            Name = "Sandwiches"
        },
        new()
        {
            Id = Guid.Parse("1728394a-5b6c-3def-0123-456789012345"),
            Name = "Salads"
        },
        new()
        {
            Id = Guid.Parse("28394a5b-6c7d-4ef0-1234-567890123456"),
            Name = "Soup"
        },
        new()
        {
            Id = Guid.Parse("394a5b6c-7d8e-5f01-2345-678901234567"),
            Name = "Pancakes"
        },
        new()
        {
            Id = Guid.Parse("4a5b6c7d-8e9f-6012-3456-789012345678"),
            Name = "Waffles"
        },
        new()
        {
            Id = Guid.Parse("5b6c7d8e-9f01-7123-4567-890123456789"),
            Name = "Smoothies"
        },
        new()
        {
            Id = Guid.Parse("6c7d8e9f-0123-8234-5678-901234567890"),
            Name = "Juice"
        },
        new()
        {
            Id = Guid.Parse("7d8e9f01-2345-9345-6789-012345678901"),
            Name = "Ice Cream"
        },
        new()
        {
            Id = Guid.Parse("8e9f0123-4567-a456-7890-123456789012"),
            Name = "Chocolate"
        },
        new()
        {
            Id = Guid.Parse("9f012345-6789-b567-8901-234567890123"),
            Name = "Coffee"
        },
        new()
        {
            Id = Guid.Parse("01234567-89ab-c678-9012-345678901234"),
            Name = "Tea"
        },
        new()
        {
            Id = Guid.Parse("12345678-9abc-d789-0123-456789012345"),
            Name = "Dumplings"
        },
        new()
        {
            Id = Guid.Parse("23456789-abcd-e890-1234-567890123456"),
            Name = "Tacos"
        },
        new()
        {
            Id = Guid.Parse("3456789a-bcde-f901-2345-678901234567"),
            Name = "Burritos"
        },
        new()
        {
            Id = Guid.Parse("456789ab-cdef-0a12-3456-789012345678"),
            Name = "Ramen"
        },
        new()
        {
            Id = Guid.Parse("56789abc-def0-1b23-4567-890123456789"),
            Name = "Pho"
        },
        new()
        {
            Id = Guid.Parse("6789abcd-ef01-2c34-5678-901234567890"),
            Name = "Curry"
        },
        new()
        {
            Id = Guid.Parse("789abcde-f012-3d45-6789-012345678901"),
            Name = "Bakery"
        },
        new()
        {
            Id = Guid.Parse("89abcdef-0123-4e56-7890-123456789012"),
            Name = "Pastries"
        },
        new()
        {
            Id = Guid.Parse("9abcdef0-1234-5f67-8901-234567890123"),
            Name = "Cheese"
        },
        new()
        {
            Id = Guid.Parse("abcdef01-2345-6078-9012-345678901234"),
            Name = "Grill"
        },
        new()
        {
            Id = Guid.Parse("bcdef012-3456-7189-0123-456789012345"),
            Name = "Brunch"
        },
        new()
        {
            Id = Guid.Parse("cdef0123-4567-8290-1234-567890123456"),
            Name = "Late Night"
        },
        new()
        {
            Id = Guid.Parse("d0e1f2a3-b4c5-d6e7-f890-1234567890ab"),
            Name = "Healthy"
        },
        new()
        {
            Id = Guid.Parse("e1f2a3b4-c5d6-e7f8-9012-34567890abcd"),
            Name = "Fast Food"
        },
        new()
        {
            Id = Guid.Parse("f2a3b4c5-d6e7-f890-1234-567890abcdef"),
            Name = "Comfort Food"
        },
        new()
        {
            Id = Guid.Parse("90dbff82-1720-44fa-a9ea-b109a4dc7831"),
            Name = "Egyptian"
        }
    ];

    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TagModel>().HasData(data);
    }
}