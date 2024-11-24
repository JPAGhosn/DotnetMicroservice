using Glimpses.Models;
using Microsoft.EntityFrameworkCore;

namespace Glimpses.Seeders;

public static class GlimpsesSeeder
{
    public static List<GlimpseModel> Data = new()
    {
        // American
        new GlimpseModel
        {
            Id = Guid.Parse("7e2381b5-20fb-439a-9321-f7ba3c897e25"),
            VideoPath = "7e2381b5-20fb-439a-9321-f7ba3c897e25.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            ThumbnailPath = "7e2381b5-20fb-439a-9321-f7ba3c897e25.jpg",
            Name = "WHAT THE F@**!!"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("4bbb7a15-c5cf-4943-b0c0-d1805fa57e81"),
            VideoPath = "4bbb7a15-c5cf-4943-b0c0-d1805fa57e81.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            ThumbnailPath = "4bbb7a15-c5cf-4943-b0c0-d1805fa57e81.jpg",
            Name = "Chili Chicken"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("6394835f-55c5-4fb2-aca6-b91cce742b87"),
            VideoPath = "6394835f-55c5-4fb2-aca6-b91cce742b87.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            ThumbnailPath = "6394835f-55c5-4fb2-aca6-b91cce742b87.jpg",
            Name = "Rush vs Goku"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("1eb15a48-694b-4d66-ad95-e395c204dc9e"),
            VideoPath = "1eb15a48-694b-4d66-ad95-e395c204dc9e.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            ThumbnailPath = "1eb15a48-694b-4d66-ad95-e395c204dc9e.jpg",
            Name = "Get out of the way!"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("dea9eccb-9f91-46c4-b19f-70fb62590403"),
            VideoPath = "dea9eccb-9f91-46c4-b19f-70fb62590403.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            ThumbnailPath = "dea9eccb-9f91-46c4-b19f-70fb62590403.jpg",
            Name = "Angry Guy"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("032a2edc-cc1b-4c75-808e-ad466f894fb3"),
            VideoPath = "032a2edc-cc1b-4c75-808e-ad466f894fb3.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            ThumbnailPath = "032a2edc-cc1b-4c75-808e-ad466f894fb3.jpg",
            Name = "Cuisine Facile"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("b07cf239-4b53-4976-85c6-c1c8597287c4"),
            VideoPath = "b07cf239-4b53-4976-85c6-c1c8597287c4.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            ThumbnailPath = "b07cf239-4b53-4976-85c6-c1c8597287c4.jpg",
            Name = "Attacking Italy"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("b70205da-7457-4d3f-8b43-0f9cc2cd9d40"),
            VideoPath = "b70205da-7457-4d3f-8b43-0f9cc2cd9d40.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            ThumbnailPath = "b70205da-7457-4d3f-8b43-0f9cc2cd9d40.jpg",
            Name = "Never forget"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("5d26c047-4583-44f6-82e4-92c2df02f349"),
            VideoPath = "5d26c047-4583-44f6-82e4-92c2df02f349.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            ThumbnailPath = "5d26c047-4583-44f6-82e4-92c2df02f349.jpg",
            Name = "Kitchen Drama"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("51495d86-8530-47c1-b814-3afd8363a4a8"),
            VideoPath = "51495d86-8530-47c1-b814-3afd8363a4a8.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            ThumbnailPath = "51495d86-8530-47c1-b814-3afd8363a4a8.jpg",
            Name = "Let him cook"
        },

        // Lebanese
        new GlimpseModel
        {
            Id = Guid.Parse("3021b0ee-0c17-459f-a9e5-a927fd50e014"),
            VideoPath = "3021b0ee-0c17-459f-a9e5-a927fd50e014.mp4",
            CreatorId = Guid.Parse("0ec74399-11e5-4d26-b21c-8666caa884a7"),
            ThumbnailPath = "3021b0ee-0c17-459f-a9e5-a927fd50e014.jpg",
            Name = "Lebanese Doughnut"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("c5399f10-8d95-4a35-b749-06d1879ec858"),
            VideoPath = "c5399f10-8d95-4a35-b749-06d1879ec858.mp4",
            CreatorId = Guid.Parse("0ec74399-11e5-4d26-b21c-8666caa884a7"),
            ThumbnailPath = "c5399f10-8d95-4a35-b749-06d1879ec858.jpg",
            Name = "Lebanese Pizza Dessert"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("4e55e272-bd2b-4b72-b968-db0b9f924f13"),
            VideoPath = "4e55e272-bd2b-4b72-b968-db0b9f924f13.mp4",
            CreatorId = Guid.Parse("0ec74399-11e5-4d26-b21c-8666caa884a7"),
            ThumbnailPath = "4e55e272-bd2b-4b72-b968-db0b9f924f13.jpg",
            Name = "Saldito"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("93c18404-3ef3-4538-8fa5-c02526c35379"),
            VideoPath = "93c18404-3ef3-4538-8fa5-c02526c35379.mp4",
            CreatorId = Guid.Parse("0ec74399-11e5-4d26-b21c-8666caa884a7"),
            ThumbnailPath = "93c18404-3ef3-4538-8fa5-c02526c35379.jpg",
            Name = "Saladito P2"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("87694cf3-5e01-439a-9210-8fef93215ad6"),
            VideoPath = "87694cf3-5e01-439a-9210-8fef93215ad6.mp4",
            CreatorId = Guid.Parse("0ec74399-11e5-4d26-b21c-8666caa884a7"),
            ThumbnailPath = "87694cf3-5e01-439a-9210-8fef93215ad6.jpg",
            Name = "New year diet salade"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("e8fdd77b-02a6-47ba-af3f-3df9c1e13f17"),
            VideoPath = "e8fdd77b-02a6-47ba-af3f-3df9c1e13f17.mp4",
            CreatorId = Guid.Parse("0ec74399-11e5-4d26-b21c-8666caa884a7"),
            ThumbnailPath = "e8fdd77b-02a6-47ba-af3f-3df9c1e13f17.jpg",
            Name = "Chicken Salade"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("7dc64d9b-bf3d-46cd-bc6e-2cef2d3209b5"),
            VideoPath = "7dc64d9b-bf3d-46cd-bc6e-2cef2d3209b5.mp4",
            CreatorId = Guid.Parse("0ec74399-11e5-4d26-b21c-8666caa884a7"),
            ThumbnailPath = "7dc64d9b-bf3d-46cd-bc6e-2cef2d3209b5.jpg",
            Name = "Chicken Spicy Salade"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("d5bc95f2-6bd9-4fa9-938e-1179b4452241"),
            VideoPath = "d5bc95f2-6bd9-4fa9-938e-1179b4452241.mp4",
            CreatorId = Guid.Parse("0ec74399-11e5-4d26-b21c-8666caa884a7"),
            ThumbnailPath = "d5bc95f2-6bd9-4fa9-938e-1179b4452241.jpg",
            Name = "Salata ya Salata"
        },

        // French
        new GlimpseModel
        {
            Id = Guid.Parse("221d417a-3925-4d5d-92eb-ec6599c0c384"),
            VideoPath = "221d417a-3925-4d5d-92eb-ec6599c0c384.mp4",
            CreatorId = Guid.Parse("d946ee8d-2797-40ed-8130-f83207158e1c"),
            ThumbnailPath = "221d417a-3925-4d5d-92eb-ec6599c0c384.jpg",
            Name = "Garlic confit"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("49977d00-d172-4300-b2e8-21ebe7ba7d2c"),
            VideoPath = "49977d00-d172-4300-b2e8-21ebe7ba7d2c.mp4",
            CreatorId = Guid.Parse("d946ee8d-2797-40ed-8130-f83207158e1c"),
            ThumbnailPath = "49977d00-d172-4300-b2e8-21ebe7ba7d2c.jpg",
            Name = "Host like a French"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("03b2c412-0d5e-4b71-a48b-bf0d769b56f2"),
            VideoPath = "03b2c412-0d5e-4b71-a48b-bf0d769b56f2.mp4",
            CreatorId = Guid.Parse("d946ee8d-2797-40ed-8130-f83207158e1c"),
            ThumbnailPath = "03b2c412-0d5e-4b71-a48b-bf0d769b56f2.jpg",
            Name = "Fruit tart"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("4cf999e3-b17d-49b4-bfee-b50223413af8"),
            VideoPath = "4cf999e3-b17d-49b4-bfee-b50223413af8.mp4",
            CreatorId = Guid.Parse("d946ee8d-2797-40ed-8130-f83207158e1c"),
            ThumbnailPath = "4cf999e3-b17d-49b4-bfee-b50223413af8.jpg",
            Name = "Most expensive cake"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("d446d991-4075-4ca4-a6d4-2aff6317ec15"),
            VideoPath = "d446d991-4075-4ca4-a6d4-2aff6317ec15.mp4",
            CreatorId = Guid.Parse("d946ee8d-2797-40ed-8130-f83207158e1c"),
            ThumbnailPath = "d446d991-4075-4ca4-a6d4-2aff6317ec15.jpg",
            Name = "Matcha vanilla cake"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("3e8f6dd1-656b-41e0-9cde-8824d05b9e38"),
            VideoPath = "3e8f6dd1-656b-41e0-9cde-8824d05b9e38.mp4",
            CreatorId = Guid.Parse("d946ee8d-2797-40ed-8130-f83207158e1c"),
            ThumbnailPath = "3e8f6dd1-656b-41e0-9cde-8824d05b9e38.jpg",
            Name = "French girl in London"
        },

        // Korean
        new GlimpseModel
        {
            Id = Guid.Parse("a4c9eecf-d791-4cfe-af94-11a09498e6fa"),
            VideoPath = "3e8f6dd1-656b-41e0-9cde-8824d05b9e38.mp4",
            CreatorId = Guid.Parse("b1c3b501-4b61-4c23-89de-6745d1044f13"),
            ThumbnailPath = "a4c9eecf-d791-4cfe-af94-11a09498e6fa.jpg",
            Name = "Super poutine"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("3f4d335a-41a1-45ee-a024-773504bf88f9"),
            VideoPath = "3f4d335a-41a1-45ee-a024-773504bf88f9.mp4",
            CreatorId = Guid.Parse("b1c3b501-4b61-4c23-89de-6745d1044f13"),
            ThumbnailPath = "3f4d335a-41a1-45ee-a024-773504bf88f9.jpg",
            Name = "Korean Hot Dough"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("8e41d5d1-c96d-4971-bfd0-d7ce1f05eae7"),
            VideoPath = "8e41d5d1-c96d-4971-bfd0-d7ce1f05eae7.mp4",
            CreatorId = Guid.Parse("b1c3b501-4b61-4c23-89de-6745d1044f13"),
            ThumbnailPath = "8e41d5d1-c96d-4971-bfd0-d7ce1f05eae7.jpg",
            Name = "Meat me again"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("c7f26ca2-536e-4d5d-b656-bef531500957"),
            VideoPath = "c7f26ca2-536e-4d5d-b656-bef531500957.mp4",
            CreatorId = Guid.Parse("b1c3b501-4b61-4c23-89de-6745d1044f13"),
            ThumbnailPath = "c7f26ca2-536e-4d5d-b656-bef531500957.jpg",
            Name = "Wagnu Meat"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("b5fadc05-70d1-48f6-bed3-f11b99941e53"),
            VideoPath = "b5fadc05-70d1-48f6-bed3-f11b99941e53.mp4",
            CreatorId = Guid.Parse("b1c3b501-4b61-4c23-89de-6745d1044f13"),
            ThumbnailPath = "b5fadc05-70d1-48f6-bed3-f11b99941e53.jpg",
            Name = "Moooo!"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("2aa28b07-02db-42d7-a6a7-151b8ceded5d"),
            VideoPath = "2aa28b07-02db-42d7-a6a7-151b8ceded5d.mp4",
            CreatorId = Guid.Parse("b1c3b501-4b61-4c23-89de-6745d1044f13"),
            ThumbnailPath = "2aa28b07-02db-42d7-a6a7-151b8ceded5d.jpg",
            Name = "Master of Meat"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("6fdc4be8-0dd7-43c7-b617-a14784edd7fe"),
            VideoPath = "6fdc4be8-0dd7-43c7-b617-a14784edd7fe.mp4",
            CreatorId = Guid.Parse("b1c3b501-4b61-4c23-89de-6745d1044f13"),
            ThumbnailPath = "6fdc4be8-0dd7-43c7-b617-a14784edd7fe.jpg",
            Name = "Eggs again"
        },

        // Asian
        new GlimpseModel
        {
            Id = Guid.Parse("ad82e403-47f2-4844-81da-479e70e4f750"),
            VideoPath = "ad82e403-47f2-4844-81da-479e70e4f750.mp4",
            CreatorId = Guid.Parse("902612bf-823f-40b0-9247-7a0a9aa7c6a6"),
            ThumbnailPath = "ad82e403-47f2-4844-81da-479e70e4f750.jpg",
            Name = "Eggs Forever"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("aed8c187-3fab-4703-9091-bbe500cd2404"),
            VideoPath = "aed8c187-3fab-4703-9091-bbe500cd2404.mp4",
            CreatorId = Guid.Parse("902612bf-823f-40b0-9247-7a0a9aa7c6a6"),
            ThumbnailPath = "aed8c187-3fab-4703-9091-bbe500cd2404.jpg",
            Name = "Chicken nuggets"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("6db12951-7f53-4f81-b99e-91b7adf74d2e"),
            VideoPath = "6db12951-7f53-4f81-b99e-91b7adf74d2e.mp4",
            CreatorId = Guid.Parse("902612bf-823f-40b0-9247-7a0a9aa7c6a6"),
            ThumbnailPath = "6db12951-7f53-4f81-b99e-91b7adf74d2e.jpg",
            Name = "Chicken wings"
        },

        // Japanese
        new GlimpseModel
        {
            Id = Guid.Parse("9b9392dc-927e-48b9-87db-8d9a8b0bcf33"),
            VideoPath = "b49c5523-117e-4666-8f3b-ca5bd96f2ede.mp4",
            CreatorId = Guid.Parse("b49c5523-117e-4666-8f3b-ca5bd96f2ede"),
            ThumbnailPath = "9b9392dc-927e-48b9-87db-8d9a8b0bcf33.jpg",
            Name = "Fried Noodles"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("096dcfab-16d2-4b75-ae6d-2073ea43a425"),
            VideoPath = "096dcfab-16d2-4b75-ae6d-2073ea43a425.mp4",
            CreatorId = Guid.Parse("b49c5523-117e-4666-8f3b-ca5bd96f2ede"),
            ThumbnailPath = "096dcfab-16d2-4b75-ae6d-2073ea43a425.jpg",
            Name = "Green beans casserole"
        },

        // Egyptian
        new GlimpseModel
        {
            Id = Guid.Parse("f23ddf95-e03e-474e-9a10-1d9f48ccd979"),
            VideoPath = "f23ddf95-e03e-474e-9a10-1d9f48ccd979.mp4",
            CreatorId = Guid.Parse("4d4aba40-d0c3-4cdf-9d86-10a92c08b8a2"),
            ThumbnailPath = "f23ddf95-e03e-474e-9a10-1d9f48ccd979.jpg",
            Name = "Green beans casserole"
        },
        new GlimpseModel
        {
            Id = Guid.Parse("f0eede5f-29b3-4c3a-8047-9773fd326535"),
            VideoPath = "f0eede5f-29b3-4c3a-8047-9773fd326535.mp4",
            CreatorId = Guid.Parse("4d4aba40-d0c3-4cdf-9d86-10a92c08b8a2"),
            ThumbnailPath = "f0eede5f-29b3-4c3a-8047-9773fd326535.jpg",
            Name = "Green beans casserole"
        }

        // Mexican
        // No data
    };

    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<GlimpseModel>().HasData(Data);
    }
}