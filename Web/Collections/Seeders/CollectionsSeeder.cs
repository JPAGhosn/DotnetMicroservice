using Collections.Models;
using Microsoft.EntityFrameworkCore;

namespace Collections.Seeders;

public static class CollectionsSeeder
{
    public static List<CollectionModel> Data = new()
    {
        new CollectionModel
        {
            Id = Guid.Parse("1c54b08c-37f5-4f35-9dcc-e04aef5297e4"),
            Name = "Asian Cuisine",
            CoverPath1 = "193b9092-1f68-45ce-bdb4-1c362c7f50ee.png",
            CoverPath2 = "963fbaca-aaaf-4c5d-a88d-b385fb2c80ff.png",
            CoverPath3 = "771c0417-da5e-4901-809d-844fb3abfdd4.png",
            CreatorId = Guid.Parse("ebf82549-cfeb-4f3f-a753-21dfcc0ccb61"),
            NumberOfFollowers = 453232,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },

        new CollectionModel
        {
            Id = Guid.Parse("47e69648-e8ec-45b6-aa37-0221939e9e4a"),
            Name = "Lebanese Cuisine",
            CoverPath1 = "9dae1b65-0507-4625-a64f-8cd375d1034c.png",
            CoverPath2 = "313a8ab8-f2b4-45c3-9dd1-a9498ea94a39.png",
            CoverPath3 = "55d9272f-851a-4638-abbb-92b92ccb031e.png",
            CreatorId = Guid.Parse("6b7ffda1-eaab-43bd-b61d-bf0d35766590"),
            NumberOfFollowers = 6547687,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },

        new CollectionModel
        {
            Id = Guid.Parse("13ec4bce-faa1-4a17-9d7f-ec03e88b1708"),
            Name = "Korean Cuisine",
            CoverPath1 = "51c48c53-8299-4b52-b581-a38516effb12.png",
            CoverPath2 = "91f71ec1-ec59-4745-93e4-2cebe4bf5d60.png",
            CoverPath3 = "9fcb71bc-86b2-415c-95df-770651b05e05.png",
            CreatorId = Guid.Parse("18590908-6512-4948-95ca-14ebb9b75652"),
            NumberOfFollowers = 546,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("0e45bbbb-0882-41fc-a99f-3aaf045d6845"),
            Name = "French Cuisine",
            CoverPath1 = "d7c4877c-bfc3-4519-b21d-f8d01da3d729.png",
            CoverPath2 = "738f7ad7-4060-4a74-bcc7-c29ca4e23ce2.png",
            CoverPath3 = "c7494117-5946-4efe-a26d-ee3a6d380d15.png",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            NumberOfFollowers = 234343,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("18db4d9b-6a51-4f7b-8712-c2a477847d6a"),
            Name = "American Cuisine",
            CoverPath1 = "d4d00bef-c865-495d-8c96-eec230bcf1ac.png",
            CoverPath2 = "10b97e4c-30f2-499d-9f8d-0c0d79af8822.png",
            CoverPath3 = "0a59a6e6-a583-417e-81ad-89e7cb55b8f4.png",
            CreatorId = Guid.Parse("bd0f2bb7-001b-4990-a15d-48959bfd66dc"),
            NumberOfFollowers = 54354565476,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("83681495-a381-4bcf-a075-5d18cf0a646e"),
            Name = "Egyptian Cuisine",
            CoverPath1 = "2ec1d62e-953f-481a-a1cd-ad145deae37a.png",
            CoverPath2 = "cded9fee-5057-4b91-9e50-a812248458bd.png",
            CoverPath3 = "17d56165-5365-4bf1-80db-3aea91f9d115.png",
            CreatorId = Guid.Parse("0fe05ee0-1254-4217-ad9b-9b8c8ba2bf46"),
            NumberOfFollowers = 324,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("327b9523-ea66-4e60-ab9f-57aafff11f4e"),
            Name = "Japanese Cuisine",
            CoverPath1 = "d55f4548-c2e6-4816-892e-7f520fbc311b.png",
            CoverPath2 = "c7cbd853-5d60-4096-bd82-a33191cdd2ca.png",
            CoverPath3 = "f656c46f-eb2b-4808-93b8-78f8c85ddbe9.png",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            NumberOfFollowers = 7656765,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("967aa6eb-2372-42b8-bf06-338cfb196b04"),
            Name = "Mexican Cuisine",
            CoverPath1 = "2bec25d1-0d12-4445-9aee-38b18dc27c41.png",
            CoverPath2 = "02bb5e76-0b06-4d99-b9a9-cef5ee6bb8df.png",
            CoverPath3 = "2769be35-6c35-47cb-8a0d-c7fb68d6cb8b.png",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            NumberOfFollowers = 4354,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },

        // Mine
        new CollectionModel
        {
            Id = Guid.Parse("295fe31c-3fc8-485a-a878-75ac57616a43"),
            Name = "My Favorites",
            CoverPath1 = "2bec25d1-0d12-4445-9aee-38b18dc27c41.png",
            CoverPath2 = "02bb5e76-0b06-4d99-b9a9-cef5ee6bb8df.png",
            CoverPath3 = "2769be35-6c35-47cb-8a0d-c7fb68d6cb8b.png",
            CreatorId = Guid.Parse("34814847-360e-439e-83cf-d8ee775f547d"),
            NumberOfFollowers = 30,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("78cc9495-9628-4a34-8121-4e179a61954e"),
            Name = "Night Dishes",
            CoverPath1 = "d7c4877c-bfc3-4519-b21d-f8d01da3d729.png",
            CoverPath2 = "d7c4877c-bfc3-4519-b21d-f8d01da3d729.png",
            CoverPath3 = "c7494117-5946-4efe-a26d-ee3a6d380d15.png",
            CreatorId = Guid.Parse("34814847-360e-439e-83cf-d8ee775f547d"),
            NumberOfFollowers = 78,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("b9df8866-2c0b-47bd-a9fe-07ffff2f1664"),
            Name = "Morning Ideas",
            CoverPath1 = "10b97e4c-30f2-499d-9f8d-0c0d79af8822.png",
            CoverPath2 = "d4d00bef-c865-495d-8c96-eec230bcf1ac.png",
            CoverPath3 = "0a59a6e6-a583-417e-81ad-89e7cb55b8f4.png",
            CreatorId = Guid.Parse("34814847-360e-439e-83cf-d8ee775f547d"),
            NumberOfFollowers = 78,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("9b1a30a1-9f0d-4fe8-a897-9f67a850d51b"),
            Name = "Dinner Ideas for my GF",
            CoverPath1 = "d55f4548-c2e6-4816-892e-7f520fbc311b.png",
            CoverPath2 = "c7cbd853-5d60-4096-bd82-a33191cdd2ca.png",
            CoverPath3 = "f656c46f-eb2b-4808-93b8-78f8c85ddbe9.png",
            CreatorId = Guid.Parse("34814847-360e-439e-83cf-d8ee775f547d"),
            NumberOfFollowers = 78,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("85bf1878-470d-4331-ad05-4c632cb1cde3"),
            Name = "Family Dinner Ideas",
            CoverPath1 = "d55f4548-c2e6-4816-892e-7f520fbc311b.png",
            CoverPath2 = "c7cbd853-5d60-4096-bd82-a33191cdd2ca.png",
            CoverPath3 = "f656c46f-eb2b-4808-93b8-78f8c85ddbe9.png",
            CreatorId = Guid.Parse("34814847-360e-439e-83cf-d8ee775f547d"),
            NumberOfFollowers = 1002,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("89ad74a5-faac-4d23-a239-b5262775041f"),
            Name = "High in Protein",
            CoverPath1 = "d55f4548-c2e6-4816-892e-7f520fbc311b.png",
            CoverPath2 = "c7cbd853-5d60-4096-bd82-a33191cdd2ca.png",
            CoverPath3 = "f656c46f-eb2b-4808-93b8-78f8c85ddbe9.png",
            CreatorId = Guid.Parse("34814847-360e-439e-83cf-d8ee775f547d"),
            NumberOfFollowers = 1002,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("05cf846a-6a2b-423e-830b-c707bbb478c6"),
            Name = "Low in calories",
            CoverPath1 = "d55f4548-c2e6-4816-892e-7f520fbc311b.png",
            CoverPath2 = "c7cbd853-5d60-4096-bd82-a33191cdd2ca.png",
            CoverPath3 = "f656c46f-eb2b-4808-93b8-78f8c85ddbe9.png",
            CreatorId = Guid.Parse("34814847-360e-439e-83cf-d8ee775f547d"),
            NumberOfFollowers = 1002,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("1c48d37c-906e-49b6-aecc-306354f61caa"),
            Name = "Ready in less than 5 minutes",
            CoverPath1 = "d55f4548-c2e6-4816-892e-7f520fbc311b.png",
            CoverPath2 = "c7cbd853-5d60-4096-bd82-a33191cdd2ca.png",
            CoverPath3 = "f656c46f-eb2b-4808-93b8-78f8c85ddbe9.png",
            CreatorId = Guid.Parse("34814847-360e-439e-83cf-d8ee775f547d"),
            NumberOfFollowers = 1002,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("4d08f121-b318-4956-b4a9-d4c21c619994"),
            Name = "3 stars Michelin",
            CoverPath1 = "d55f4548-c2e6-4816-892e-7f520fbc311b.png",
            CoverPath2 = "c7cbd853-5d60-4096-bd82-a33191cdd2ca.png",
            CoverPath3 = "f656c46f-eb2b-4808-93b8-78f8c85ddbe9.png",
            CreatorId = Guid.Parse("34814847-360e-439e-83cf-d8ee775f547d"),
            NumberOfFollowers = 1002,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("ff8a52c6-7898-4062-aeb4-550797177b06"),
            Name = "For my Korean GF",
            CoverPath1 = "d55f4548-c2e6-4816-892e-7f520fbc311b.png",
            CoverPath2 = "c7cbd853-5d60-4096-bd82-a33191cdd2ca.png",
            CoverPath3 = "f656c46f-eb2b-4808-93b8-78f8c85ddbe9.png",
            CreatorId = Guid.Parse("34814847-360e-439e-83cf-d8ee775f547d"),
            NumberOfFollowers = 1002,
            PublishedDate = DateTime.Now.ToUniversalTime()
        }
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CollectionModel>().HasData(Data);
    }
}