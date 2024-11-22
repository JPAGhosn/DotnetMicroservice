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
            CoverPath1 = "1c54b08c-37f5-4f35-9dcc-e04aef5297e4--1.avif",
            CoverPath2 = "1c54b08c-37f5-4f35-9dcc-e04aef5297e4--2.avif",
            CoverPath3 = "1c54b08c-37f5-4f35-9dcc-e04aef5297e4--3.avif",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            NumberOfFollowers = 1342,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("47e69648-e8ec-45b6-aa37-0221939e9e4a"),
            Name = "Asian Cuisine",
            CoverPath1 = "47e69648-e8ec-45b6-aa37-0221939e9e4a--1.avif",
            CoverPath2 = "47e69648-e8ec-45b6-aa37-0221939e9e4a--2.avif",
            CoverPath3 = "47e69648-e8ec-45b6-aa37-0221939e9e4a--3.avif",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            NumberOfFollowers = 1342,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("13ec4bce-faa1-4a17-9d7f-ec03e88b1708"),
            Name = "Asian Cuisine",
            CoverPath1 = "13ec4bce-faa1-4a17-9d7f-ec03e88b1708--1.avif",
            CoverPath2 = "13ec4bce-faa1-4a17-9d7f-ec03e88b1708--2.avif",
            CoverPath3 = "13ec4bce-faa1-4a17-9d7f-ec03e88b1708--3.avif",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            NumberOfFollowers = 1342,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("0e45bbbb-0882-41fc-a99f-3aaf045d6845"),
            Name = "Asian Cuisine",
            CoverPath1 = "0e45bbbb-0882-41fc-a99f-3aaf045d6845--1.avif",
            CoverPath2 = "0e45bbbb-0882-41fc-a99f-3aaf045d6845--2.avif",
            CoverPath3 = "0e45bbbb-0882-41fc-a99f-3aaf045d6845--3.avif",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            NumberOfFollowers = 1342,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("18db4d9b-6a51-4f7b-8712-c2a477847d6a"),
            Name = "Asian Cuisine",
            CoverPath1 = "18db4d9b-6a51-4f7b-8712-c2a477847d6a--1.avif",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            NumberOfFollowers = 1342,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("949f8b31-7554-4028-b691-23fc251348e2"),
            Name = "Asian Cuisine",
            CoverPath1 = "949f8b31-7554-4028-b691-23fc251348e2--1.avif",
            CoverPath2 = "949f8b31-7554-4028-b691-23fc251348e2--2.avif",
            CoverPath3 = "949f8b31-7554-4028-b691-23fc251348e2--3.avif",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            NumberOfFollowers = 1342,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("83681495-a381-4bcf-a075-5d18cf0a646e"),
            Name = "Asian Cuisine",
            CoverPath1 = "83681495-a381-4bcf-a075-5d18cf0a646e--1.avif",
            CoverPath2 = "83681495-a381-4bcf-a075-5d18cf0a646e--2.avif",
            CoverPath3 = "83681495-a381-4bcf-a075-5d18cf0a646e--3.avif",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            NumberOfFollowers = 1342,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("1b8ab95a-930a-4e8f-b6cd-e3e5678d4c98"),
            Name = "Asian Cuisine",
            CoverPath1 = "1b8ab95a-930a-4e8f-b6cd-e3e5678d4c98--1.avif",
            CoverPath2 = "1b8ab95a-930a-4e8f-b6cd-e3e5678d4c98--2.avif",
            CoverPath3 = "1b8ab95a-930a-4e8f-b6cd-e3e5678d4c98--3.avif",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            NumberOfFollowers = 1342,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("327b9523-ea66-4e60-ab9f-57aafff11f4e"),
            Name = "Asian Cuisine",
            CoverPath1 = "327b9523-ea66-4e60-ab9f-57aafff11f4e--1.avif",
            CoverPath2 = "327b9523-ea66-4e60-ab9f-57aafff11f4e--2.avif",
            CoverPath3 = "327b9523-ea66-4e60-ab9f-57aafff11f4e--3.avif",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            NumberOfFollowers = 1342,
            PublishedDate = DateTime.Now.ToUniversalTime()
        },
        new CollectionModel
        {
            Id = Guid.Parse("967aa6eb-2372-42b8-bf06-338cfb196b04"),
            Name = "Asian Cuisine",
            CoverPath1 = "967aa6eb-2372-42b8-bf06-338cfb196b04--1.avif",
            CoverPath2 = "967aa6eb-2372-42b8-bf06-338cfb196b04--2.avif",
            CoverPath3 = "967aa6eb-2372-42b8-bf06-338cfb196b04--3.avif",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            NumberOfFollowers = 1342,
            PublishedDate = DateTime.Now.ToUniversalTime()
        }
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CollectionModel>().HasData(Data);
    }
}