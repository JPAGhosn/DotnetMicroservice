using Collections.Models.Pivots;
using Microsoft.EntityFrameworkCore;

namespace Collections.Seeders;

public class CollectionHasTagSeeder
{
    public static List<CollectionHasTag> Data = new()
    {
        // Asian
        new CollectionHasTag
        {
            CollectionId = Guid.Parse("1c54b08c-37f5-4f35-9dcc-e04aef5297e4"),
            TagId = Guid.Parse("67fd736c-ac11-4c07-a8e8-7da245828866")
        },

        // Lebanese
        new CollectionHasTag
        {
            CollectionId = Guid.Parse("47e69648-e8ec-45b6-aa37-0221939e9e4a"),
            TagId = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3")
        },

        // Korean
        new CollectionHasTag
        {
            CollectionId = Guid.Parse("13ec4bce-faa1-4a17-9d7f-ec03e88b1708"),
            TagId = Guid.Parse("781f1e8a-24a5-435c-a8cb-8d66b4d8495e")
        },

        // French
        new CollectionHasTag
        {
            CollectionId = Guid.Parse("0e45bbbb-0882-41fc-a99f-3aaf045d6845"),
            TagId = Guid.Parse("a1c0b32c-3c54-46b8-a99c-7b6a0a839028")
        },

        // American
        new CollectionHasTag
        {
            CollectionId = Guid.Parse("18db4d9b-6a51-4f7b-8712-c2a477847d6a"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },

        // Egyptian
        new CollectionHasTag
        {
            CollectionId = Guid.Parse("83681495-a381-4bcf-a075-5d18cf0a646e"),
            TagId = Guid.Parse("90dbff82-1720-44fa-a9ea-b109a4dc7831")
        },

        // Japanese
        new CollectionHasTag
        {
            CollectionId = Guid.Parse("327b9523-ea66-4e60-ab9f-57aafff11f4e"),
            TagId = Guid.Parse("b2d0f3ab-8f52-4a63-8fdd-b0f7a6e89c3d")
        },

        // Mexican
        new CollectionHasTag
        {
            CollectionId = Guid.Parse("967aa6eb-2372-42b8-bf06-338cfb196b04"),
            TagId = Guid.Parse("f2c9f40f-c9b0-4897-b29f-e4b5d27b85cc")
        }
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CollectionHasTag>().HasData(Data);
    }
}