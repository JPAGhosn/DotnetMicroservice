using Collections.Models;
using Microsoft.EntityFrameworkCore;

namespace Collections.Seeders;

public static class RecipesSeeder
{
    public static List<RecipeModel> Data = new()
    {
        new RecipeModel
        {
            Id = Guid.Parse("eba67b60-9c62-4dc6-a14a-b1d50fea7d1f"),
            ExternalId = Guid.Parse("1e7acbcb-a575-4511-ae19-b5971177a15c")
        },
        new RecipeModel
        {
            Id = Guid.Parse("0b299c7a-493d-4c87-a7f4-a77564499896"),
            ExternalId = Guid.Parse("458b0559-39b2-4c17-8303-464f73aaaa0c")
        },
        new RecipeModel
        {
            Id = Guid.Parse("5ccda7a8-4040-4b25-9d4e-d0c4bd3aeac5"),
            ExternalId = Guid.Parse("9ecd7941-eafd-4b6a-b129-f3808c3d9bfc")
        },

        //// Lebanese
        new RecipeModel
        {
            Id = Guid.Parse("9dae1b65-0507-4625-a64f-8cd375d1034c"),
            ExternalId = Guid.Parse("9dae1b65-0507-4625-a64f-8cd375d1034c")
        },
        new RecipeModel
        {
            Id = Guid.Parse("313a8ab8-f2b4-45c3-9dd1-a9498ea94a39"),
            ExternalId = Guid.Parse("313a8ab8-f2b4-45c3-9dd1-a9498ea94a39")
        },
        new RecipeModel
        {
            Id = Guid.Parse("88313bf8-1510-4659-b301-e0d1f6629721"),
            ExternalId = Guid.Parse("88313bf8-1510-4659-b301-e0d1f6629721")
        },
        new RecipeModel
        {
            Id = Guid.Parse("55d9272f-851a-4638-abbb-92b92ccb031e"),
            ExternalId = Guid.Parse("55d9272f-851a-4638-abbb-92b92ccb031e")
        },

        //// French
        new RecipeModel
        {
            Id = Guid.Parse("d7c4877c-bfc3-4519-b21d-f8d01da3d729"),
            ExternalId = Guid.Parse("d7c4877c-bfc3-4519-b21d-f8d01da3d729")
        },
        new RecipeModel
        {
            Id = Guid.Parse("738f7ad7-4060-4a74-bcc7-c29ca4e23ce2"),
            ExternalId = Guid.Parse("738f7ad7-4060-4a74-bcc7-c29ca4e23ce2")
        },
        new RecipeModel
        {
            Id = Guid.Parse("c7494117-5946-4efe-a26d-ee3a6d380d15"),
            ExternalId = Guid.Parse("c7494117-5946-4efe-a26d-ee3a6d380d15")
        },
        new RecipeModel
        {
            Id = Guid.Parse("297d7739-22fd-4c59-a8f3-1b0c818a3d9b"),
            ExternalId = Guid.Parse("297d7739-22fd-4c59-a8f3-1b0c818a3d9b")
        },

        // Korean
        new RecipeModel
        {
            Id = Guid.Parse("cd63330c-aec2-4cd3-aea7-0fe36694577b"),
            ExternalId = Guid.Parse("cd63330c-aec2-4cd3-aea7-0fe36694577b")
        },
        new RecipeModel
        {
            Id = Guid.Parse("51c48c53-8299-4b52-b581-a38516effb12"),
            ExternalId = Guid.Parse("51c48c53-8299-4b52-b581-a38516effb12")
        },
        new RecipeModel
        {
            Id = Guid.Parse("91f71ec1-ec59-4745-93e4-2cebe4bf5d60"),
            ExternalId = Guid.Parse("91f71ec1-ec59-4745-93e4-2cebe4bf5d60")
        },
        new RecipeModel
        {
            Id = Guid.Parse("9fcb71bc-86b2-415c-95df-770651b05e05"),
            ExternalId = Guid.Parse("9fcb71bc-86b2-415c-95df-770651b05e05")
        },

        // Asian
        new RecipeModel
        {
            Id = Guid.Parse("3d056e57-6e50-4d83-8ad4-55755849a575"),
            ExternalId = Guid.Parse("3d056e57-6e50-4d83-8ad4-55755849a575")
        },
        new RecipeModel
        {
            Id = Guid.Parse("193b9092-1f68-45ce-bdb4-1c362c7f50ee"),
            ExternalId = Guid.Parse("193b9092-1f68-45ce-bdb4-1c362c7f50ee")
        },
        new RecipeModel
        {
            Id = Guid.Parse("963fbaca-aaaf-4c5d-a88d-b385fb2c80ff"),
            ExternalId = Guid.Parse("963fbaca-aaaf-4c5d-a88d-b385fb2c80ff")
        },
        new RecipeModel
        {
            Id = Guid.Parse("771c0417-da5e-4901-809d-844fb3abfdd4"),
            ExternalId = Guid.Parse("771c0417-da5e-4901-809d-844fb3abfdd4")
        },

        // American
        new RecipeModel
        {
            Id = Guid.Parse("8abf601e-4f02-4bc8-9dba-0474723d908c"),
            ExternalId = Guid.Parse("8abf601e-4f02-4bc8-9dba-0474723d908c")
        },
        new RecipeModel
        {
            Id = Guid.Parse("d4d00bef-c865-495d-8c96-eec230bcf1ac"),
            ExternalId = Guid.Parse("d4d00bef-c865-495d-8c96-eec230bcf1ac")
        },
        new RecipeModel
        {
            Id = Guid.Parse("10b97e4c-30f2-499d-9f8d-0c0d79af8822"),
            ExternalId = Guid.Parse("10b97e4c-30f2-499d-9f8d-0c0d79af8822")
        },
        new RecipeModel
        {
            Id = Guid.Parse("0a59a6e6-a583-417e-81ad-89e7cb55b8f4"),
            ExternalId = Guid.Parse("0a59a6e6-a583-417e-81ad-89e7cb55b8f4")
        },

        // Japanese
        new RecipeModel
        {
            Id = Guid.Parse("d55f4548-c2e6-4816-892e-7f520fbc311b"),
            ExternalId = Guid.Parse("d55f4548-c2e6-4816-892e-7f520fbc311b")
        },
        new RecipeModel
        {
            Id = Guid.Parse("c7cbd853-5d60-4096-bd82-a33191cdd2ca"),
            ExternalId = Guid.Parse("c7cbd853-5d60-4096-bd82-a33191cdd2ca")
        },
        new RecipeModel
        {
            Id = Guid.Parse("f656c46f-eb2b-4808-93b8-78f8c85ddbe9"),
            ExternalId = Guid.Parse("f656c46f-eb2b-4808-93b8-78f8c85ddbe9")
        },

        // Egyptian
        new RecipeModel
        {
            Id = Guid.Parse("2ec1d62e-953f-481a-a1cd-ad145deae37a"),
            ExternalId = Guid.Parse("2ec1d62e-953f-481a-a1cd-ad145deae37a")
        },
        new RecipeModel
        {
            Id = Guid.Parse("cded9fee-5057-4b91-9e50-a812248458bd"),
            ExternalId = Guid.Parse("cded9fee-5057-4b91-9e50-a812248458bd")
        },
        new RecipeModel
        {
            Id = Guid.Parse("17d56165-5365-4bf1-80db-3aea91f9d115"),
            ExternalId = Guid.Parse("17d56165-5365-4bf1-80db-3aea91f9d115")
        },
        new RecipeModel
        {
            Id = Guid.Parse("6c3f64a9-750a-4422-aec7-346327e9089d"),
            ExternalId = Guid.Parse("6c3f64a9-750a-4422-aec7-346327e9089d")
        },

        // Mexican
        new RecipeModel
        {
            Id = Guid.Parse("2bec25d1-0d12-4445-9aee-38b18dc27c41"),
            ExternalId = Guid.Parse("2bec25d1-0d12-4445-9aee-38b18dc27c41")
        },
        new RecipeModel
        {
            Id = Guid.Parse("02bb5e76-0b06-4d99-b9a9-cef5ee6bb8df"),
            ExternalId = Guid.Parse("02bb5e76-0b06-4d99-b9a9-cef5ee6bb8df")
        },
        new RecipeModel
        {
            Id = Guid.Parse("2769be35-6c35-47cb-8a0d-c7fb68d6cb8b"),
            ExternalId = Guid.Parse("2769be35-6c35-47cb-8a0d-c7fb68d6cb8b")
        }
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeModel>()
            .HasData(Data);
    }
}