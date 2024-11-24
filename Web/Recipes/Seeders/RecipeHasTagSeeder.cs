using Microsoft.EntityFrameworkCore;
using Recipes.Models.Pivots;

namespace Recipes.Seeders;

public static class RecipeHasTagSeeder
{
    public static List<RecipeHasTag> Data = new()
    {
        // Lebanese
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("9dae1b65-0507-4625-a64f-8cd375d1034c"),
            TagId = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3") // Lebanese
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("313a8ab8-f2b4-45c3-9dd1-a9498ea94a39"),
            TagId = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3") // Lebanese
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("88313bf8-1510-4659-b301-e0d1f6629721"),
            TagId = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3") // Lebanese
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("55d9272f-851a-4638-abbb-92b92ccb031e"),
            TagId = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3") // Lebanese
        },

        // French
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("d7c4877c-bfc3-4519-b21d-f8d01da3d729"),
            TagId = Guid.Parse("a1c0b32c-3c54-46b8-a99c-7b6a0a839028")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("738f7ad7-4060-4a74-bcc7-c29ca4e23ce2"),
            TagId = Guid.Parse("a1c0b32c-3c54-46b8-a99c-7b6a0a839028")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("c7494117-5946-4efe-a26d-ee3a6d380d15"),
            TagId = Guid.Parse("a1c0b32c-3c54-46b8-a99c-7b6a0a839028")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("297d7739-22fd-4c59-a8f3-1b0c818a3d9b"),
            TagId = Guid.Parse("a1c0b32c-3c54-46b8-a99c-7b6a0a839028")
        },

        // Korean
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("cd63330c-aec2-4cd3-aea7-0fe36694577b"),
            TagId = Guid.Parse("781f1e8a-24a5-435c-a8cb-8d66b4d8495e")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("51c48c53-8299-4b52-b581-a38516effb12"),
            TagId = Guid.Parse("781f1e8a-24a5-435c-a8cb-8d66b4d8495e")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("91f71ec1-ec59-4745-93e4-2cebe4bf5d60"),
            TagId = Guid.Parse("781f1e8a-24a5-435c-a8cb-8d66b4d8495e")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("9fcb71bc-86b2-415c-95df-770651b05e05"),
            TagId = Guid.Parse("781f1e8a-24a5-435c-a8cb-8d66b4d8495e")
        },

        // Asian
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("3d056e57-6e50-4d83-8ad4-55755849a575"),
            TagId = Guid.Parse("67fd736c-ac11-4c07-a8e8-7da245828866")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("193b9092-1f68-45ce-bdb4-1c362c7f50ee"),
            TagId = Guid.Parse("67fd736c-ac11-4c07-a8e8-7da245828866")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("963fbaca-aaaf-4c5d-a88d-b385fb2c80ff"),
            TagId = Guid.Parse("67fd736c-ac11-4c07-a8e8-7da245828866")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("771c0417-da5e-4901-809d-844fb3abfdd4"),
            TagId = Guid.Parse("67fd736c-ac11-4c07-a8e8-7da245828866")
        },


        // American
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("8abf601e-4f02-4bc8-9dba-0474723d908c"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("d4d00bef-c865-495d-8c96-eec230bcf1ac"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("10b97e4c-30f2-499d-9f8d-0c0d79af8822"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("0a59a6e6-a583-417e-81ad-89e7cb55b8f4"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },

        // Japanese
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("d55f4548-c2e6-4816-892e-7f520fbc311b"),
            TagId = Guid.Parse("b2d0f3ab-8f52-4a63-8fdd-b0f7a6e89c3d")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("c7cbd853-5d60-4096-bd82-a33191cdd2ca"),
            TagId = Guid.Parse("b2d0f3ab-8f52-4a63-8fdd-b0f7a6e89c3d")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("f656c46f-eb2b-4808-93b8-78f8c85ddbe9"),
            TagId = Guid.Parse("b2d0f3ab-8f52-4a63-8fdd-b0f7a6e89c3d")
        },

        // Egyptian
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("2ec1d62e-953f-481a-a1cd-ad145deae37a"),
            TagId = Guid.Parse("90dbff82-1720-44fa-a9ea-b109a4dc7831")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("cded9fee-5057-4b91-9e50-a812248458bd"),
            TagId = Guid.Parse("90dbff82-1720-44fa-a9ea-b109a4dc7831")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("17d56165-5365-4bf1-80db-3aea91f9d115"),
            TagId = Guid.Parse("90dbff82-1720-44fa-a9ea-b109a4dc7831")
        },

        // Mexican
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("2bec25d1-0d12-4445-9aee-38b18dc27c41"),
            TagId = Guid.Parse("f2c9f40f-c9b0-4897-b29f-e4b5d27b85cc")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("02bb5e76-0b06-4d99-b9a9-cef5ee6bb8df"),
            TagId = Guid.Parse("f2c9f40f-c9b0-4897-b29f-e4b5d27b85cc")
        },
        new RecipeHasTag
        {
            RecipeId = Guid.Parse("2769be35-6c35-47cb-8a0d-c7fb68d6cb8b"),
            TagId = Guid.Parse("f2c9f40f-c9b0-4897-b29f-e4b5d27b85cc")
        }
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeHasTag>().HasData(Data);
    }
}