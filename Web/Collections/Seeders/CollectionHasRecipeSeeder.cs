using Collections.Models.Pivots;
using Microsoft.EntityFrameworkCore;

namespace Collections.Seeders;

public static class CollectionHasRecipeSeeder
{
    public static List<CollectionHasRecipe> Data = new()
    {
        // Lebanese
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("47e69648-e8ec-45b6-aa37-0221939e9e4a"),
            RecipeId = Guid.Parse("9dae1b65-0507-4625-a64f-8cd375d1034c")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("47e69648-e8ec-45b6-aa37-0221939e9e4a"),
            RecipeId = Guid.Parse("313a8ab8-f2b4-45c3-9dd1-a9498ea94a39")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("47e69648-e8ec-45b6-aa37-0221939e9e4a"),
            RecipeId = Guid.Parse("88313bf8-1510-4659-b301-e0d1f6629721")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("47e69648-e8ec-45b6-aa37-0221939e9e4a"),
            RecipeId = Guid.Parse("55d9272f-851a-4638-abbb-92b92ccb031e")
        },

        // French
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("0e45bbbb-0882-41fc-a99f-3aaf045d6845"),
            RecipeId = Guid.Parse("d7c4877c-bfc3-4519-b21d-f8d01da3d729")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("0e45bbbb-0882-41fc-a99f-3aaf045d6845"),
            RecipeId = Guid.Parse("738f7ad7-4060-4a74-bcc7-c29ca4e23ce2")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("0e45bbbb-0882-41fc-a99f-3aaf045d6845"),
            RecipeId = Guid.Parse("c7494117-5946-4efe-a26d-ee3a6d380d15")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("0e45bbbb-0882-41fc-a99f-3aaf045d6845"),
            RecipeId = Guid.Parse("297d7739-22fd-4c59-a8f3-1b0c818a3d9b")
        },

        // Korean
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("13ec4bce-faa1-4a17-9d7f-ec03e88b1708"),
            RecipeId = Guid.Parse("cd63330c-aec2-4cd3-aea7-0fe36694577b")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("13ec4bce-faa1-4a17-9d7f-ec03e88b1708"),
            RecipeId = Guid.Parse("51c48c53-8299-4b52-b581-a38516effb12")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("13ec4bce-faa1-4a17-9d7f-ec03e88b1708"),
            RecipeId = Guid.Parse("91f71ec1-ec59-4745-93e4-2cebe4bf5d60")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("13ec4bce-faa1-4a17-9d7f-ec03e88b1708"),
            RecipeId = Guid.Parse("9fcb71bc-86b2-415c-95df-770651b05e05")
        },

        // Asian
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("1c54b08c-37f5-4f35-9dcc-e04aef5297e4"),
            RecipeId = Guid.Parse("3d056e57-6e50-4d83-8ad4-55755849a575")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("1c54b08c-37f5-4f35-9dcc-e04aef5297e4"),
            RecipeId = Guid.Parse("193b9092-1f68-45ce-bdb4-1c362c7f50ee")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("1c54b08c-37f5-4f35-9dcc-e04aef5297e4"),
            RecipeId = Guid.Parse("963fbaca-aaaf-4c5d-a88d-b385fb2c80ff")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("1c54b08c-37f5-4f35-9dcc-e04aef5297e4"),
            RecipeId = Guid.Parse("771c0417-da5e-4901-809d-844fb3abfdd4")
        },

        // Amercian
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("18db4d9b-6a51-4f7b-8712-c2a477847d6a"),
            RecipeId = Guid.Parse("8abf601e-4f02-4bc8-9dba-0474723d908c")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("18db4d9b-6a51-4f7b-8712-c2a477847d6a"),
            RecipeId = Guid.Parse("d4d00bef-c865-495d-8c96-eec230bcf1ac")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("18db4d9b-6a51-4f7b-8712-c2a477847d6a"),
            RecipeId = Guid.Parse("10b97e4c-30f2-499d-9f8d-0c0d79af8822")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("18db4d9b-6a51-4f7b-8712-c2a477847d6a"),
            RecipeId = Guid.Parse("0a59a6e6-a583-417e-81ad-89e7cb55b8f4")
        },

        // Japanese
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("327b9523-ea66-4e60-ab9f-57aafff11f4e"),
            RecipeId = Guid.Parse("d55f4548-c2e6-4816-892e-7f520fbc311b")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("327b9523-ea66-4e60-ab9f-57aafff11f4e"),
            RecipeId = Guid.Parse("c7cbd853-5d60-4096-bd82-a33191cdd2ca")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("327b9523-ea66-4e60-ab9f-57aafff11f4e"),
            RecipeId = Guid.Parse("f656c46f-eb2b-4808-93b8-78f8c85ddbe9")
        },

        // Egyptian
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("83681495-a381-4bcf-a075-5d18cf0a646e"),
            RecipeId = Guid.Parse("2ec1d62e-953f-481a-a1cd-ad145deae37a")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("83681495-a381-4bcf-a075-5d18cf0a646e"),
            RecipeId = Guid.Parse("cded9fee-5057-4b91-9e50-a812248458bd")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("83681495-a381-4bcf-a075-5d18cf0a646e"),
            RecipeId = Guid.Parse("17d56165-5365-4bf1-80db-3aea91f9d115")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("83681495-a381-4bcf-a075-5d18cf0a646e"),
            RecipeId = Guid.Parse("6c3f64a9-750a-4422-aec7-346327e9089d")
        },

        // Mexican
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("967aa6eb-2372-42b8-bf06-338cfb196b04"),
            RecipeId = Guid.Parse("2bec25d1-0d12-4445-9aee-38b18dc27c41")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("967aa6eb-2372-42b8-bf06-338cfb196b04"),
            RecipeId = Guid.Parse("02bb5e76-0b06-4d99-b9a9-cef5ee6bb8df")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("967aa6eb-2372-42b8-bf06-338cfb196b04"),
            RecipeId = Guid.Parse("2769be35-6c35-47cb-8a0d-c7fb68d6cb8b")
        },

        // My favorites
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("295fe31c-3fc8-485a-a878-75ac57616a43"),
            RecipeId = Guid.Parse("2bec25d1-0d12-4445-9aee-38b18dc27c41")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("295fe31c-3fc8-485a-a878-75ac57616a43"),
            RecipeId = Guid.Parse("02bb5e76-0b06-4d99-b9a9-cef5ee6bb8df")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("295fe31c-3fc8-485a-a878-75ac57616a43"),
            RecipeId = Guid.Parse("2769be35-6c35-47cb-8a0d-c7fb68d6cb8b")
        },

        // Night dishes
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("78cc9495-9628-4a34-8121-4e179a61954e"),
            RecipeId = Guid.Parse("d7c4877c-bfc3-4519-b21d-f8d01da3d729")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("78cc9495-9628-4a34-8121-4e179a61954e"),
            RecipeId = Guid.Parse("738f7ad7-4060-4a74-bcc7-c29ca4e23ce2")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("78cc9495-9628-4a34-8121-4e179a61954e"),
            RecipeId = Guid.Parse("c7494117-5946-4efe-a26d-ee3a6d380d15")
        },

        // Morning Ideas
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("78cc9495-9628-4a34-8121-4e179a61954e"),
            RecipeId = Guid.Parse("10b97e4c-30f2-499d-9f8d-0c0d79af8822")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("78cc9495-9628-4a34-8121-4e179a61954e"),
            RecipeId = Guid.Parse("d4d00bef-c865-495d-8c96-eec230bcf1ac")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("78cc9495-9628-4a34-8121-4e179a61954e"),
            RecipeId = Guid.Parse("0a59a6e6-a583-417e-81ad-89e7cb55b8f4")
        },

        // Dinner Ideas for my GF
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("9b1a30a1-9f0d-4fe8-a897-9f67a850d51b"),
            RecipeId = Guid.Parse("d55f4548-c2e6-4816-892e-7f520fbc311b")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("9b1a30a1-9f0d-4fe8-a897-9f67a850d51b"),
            RecipeId = Guid.Parse("c7cbd853-5d60-4096-bd82-a33191cdd2ca")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("9b1a30a1-9f0d-4fe8-a897-9f67a850d51b"),
            RecipeId = Guid.Parse("f656c46f-eb2b-4808-93b8-78f8c85ddbe9")
        },

        // Family Dinner ideas
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("85bf1878-470d-4331-ad05-4c632cb1cde3"),
            RecipeId = Guid.Parse("d55f4548-c2e6-4816-892e-7f520fbc311b")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("85bf1878-470d-4331-ad05-4c632cb1cde3"),
            RecipeId = Guid.Parse("c7cbd853-5d60-4096-bd82-a33191cdd2ca")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("85bf1878-470d-4331-ad05-4c632cb1cde3"),
            RecipeId = Guid.Parse("f656c46f-eb2b-4808-93b8-78f8c85ddbe9")
        },

        // High in Protein
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("89ad74a5-faac-4d23-a239-b5262775041f"),
            RecipeId = Guid.Parse("d55f4548-c2e6-4816-892e-7f520fbc311b")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("89ad74a5-faac-4d23-a239-b5262775041f"),
            RecipeId = Guid.Parse("c7cbd853-5d60-4096-bd82-a33191cdd2ca")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("89ad74a5-faac-4d23-a239-b5262775041f"),
            RecipeId = Guid.Parse("f656c46f-eb2b-4808-93b8-78f8c85ddbe9")
        },

        // Low in calories
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("05cf846a-6a2b-423e-830b-c707bbb478c6"),
            RecipeId = Guid.Parse("d55f4548-c2e6-4816-892e-7f520fbc311b")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("05cf846a-6a2b-423e-830b-c707bbb478c6"),
            RecipeId = Guid.Parse("c7cbd853-5d60-4096-bd82-a33191cdd2ca")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("05cf846a-6a2b-423e-830b-c707bbb478c6"),
            RecipeId = Guid.Parse("f656c46f-eb2b-4808-93b8-78f8c85ddbe9")
        },

        // Ready in less than 5 minutes
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("1c48d37c-906e-49b6-aecc-306354f61caa"),
            RecipeId = Guid.Parse("d55f4548-c2e6-4816-892e-7f520fbc311b")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("1c48d37c-906e-49b6-aecc-306354f61caa"),
            RecipeId = Guid.Parse("c7cbd853-5d60-4096-bd82-a33191cdd2ca")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("1c48d37c-906e-49b6-aecc-306354f61caa"),
            RecipeId = Guid.Parse("f656c46f-eb2b-4808-93b8-78f8c85ddbe9")
        },

        // 3 stars michelin
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("4d08f121-b318-4956-b4a9-d4c21c619994"),
            RecipeId = Guid.Parse("d55f4548-c2e6-4816-892e-7f520fbc311b")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("4d08f121-b318-4956-b4a9-d4c21c619994"),
            RecipeId = Guid.Parse("c7cbd853-5d60-4096-bd82-a33191cdd2ca")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("4d08f121-b318-4956-b4a9-d4c21c619994"),
            RecipeId = Guid.Parse("f656c46f-eb2b-4808-93b8-78f8c85ddbe9")
        },

        // For my korean GF
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("ff8a52c6-7898-4062-aeb4-550797177b06"),
            RecipeId = Guid.Parse("d55f4548-c2e6-4816-892e-7f520fbc311b")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("ff8a52c6-7898-4062-aeb4-550797177b06"),
            RecipeId = Guid.Parse("c7cbd853-5d60-4096-bd82-a33191cdd2ca")
        },
        new CollectionHasRecipe
        {
            CollectionId = Guid.Parse("ff8a52c6-7898-4062-aeb4-550797177b06"),
            RecipeId = Guid.Parse("f656c46f-eb2b-4808-93b8-78f8c85ddbe9")
        }
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CollectionHasRecipe>()
            .HasData(Data);
    }
}