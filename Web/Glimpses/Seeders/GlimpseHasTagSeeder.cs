using Glimpses.Models.Pivots;
using Microsoft.EntityFrameworkCore;

namespace Glimpses.Seeders;

public static class GlimpseHasTagSeeder
{
    public static List<GlimpseHasTag> Data = new()
    {
        // American
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("7e2381b5-20fb-439a-9321-f7ba3c897e25"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("4bbb7a15-c5cf-4943-b0c0-d1805fa57e81"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("6394835f-55c5-4fb2-aca6-b91cce742b87"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("1eb15a48-694b-4d66-ad95-e395c204dc9e"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("dea9eccb-9f91-46c4-b19f-70fb62590403"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("032a2edc-cc1b-4c75-808e-ad466f894fb3"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("b07cf239-4b53-4976-85c6-c1c8597287c4"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("b70205da-7457-4d3f-8b43-0f9cc2cd9d40"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("5d26c047-4583-44f6-82e4-92c2df02f349"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("51495d86-8530-47c1-b814-3afd8363a4a8"),
            TagId = Guid.Parse("12345678-90ab-cdef-1234-567890abcdef")
        },

        // Lebanese
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("3021b0ee-0c17-459f-a9e5-a927fd50e014"),
            TagId = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("c5399f10-8d95-4a35-b749-06d1879ec858"),
            TagId = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("4e55e272-bd2b-4b72-b968-db0b9f924f13"),
            TagId = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("93c18404-3ef3-4538-8fa5-c02526c35379"),
            TagId = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("87694cf3-5e01-439a-9210-8fef93215ad6"),
            TagId = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("e8fdd77b-02a6-47ba-af3f-3df9c1e13f17"),
            TagId = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("7dc64d9b-bf3d-46cd-bc6e-2cef2d3209b5"),
            TagId = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("d5bc95f2-6bd9-4fa9-938e-1179b4452241"),
            TagId = Guid.Parse("53a1b26f-851f-4b9b-9e54-566cdd6208c3")
        },

        // French
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("221d417a-3925-4d5d-92eb-ec6599c0c384"),
            TagId = Guid.Parse("a1c0b32c-3c54-46b8-a99c-7b6a0a839028")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("49977d00-d172-4300-b2e8-21ebe7ba7d2c"),
            TagId = Guid.Parse("a1c0b32c-3c54-46b8-a99c-7b6a0a839028")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("03b2c412-0d5e-4b71-a48b-bf0d769b56f2"),
            TagId = Guid.Parse("a1c0b32c-3c54-46b8-a99c-7b6a0a839028")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("4cf999e3-b17d-49b4-bfee-b50223413af8"),
            TagId = Guid.Parse("a1c0b32c-3c54-46b8-a99c-7b6a0a839028")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("d446d991-4075-4ca4-a6d4-2aff6317ec15"),
            TagId = Guid.Parse("a1c0b32c-3c54-46b8-a99c-7b6a0a839028")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("3e8f6dd1-656b-41e0-9cde-8824d05b9e38"),
            TagId = Guid.Parse("a1c0b32c-3c54-46b8-a99c-7b6a0a839028")
        },

        // Korean
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("a4c9eecf-d791-4cfe-af94-11a09498e6fa"),
            TagId = Guid.Parse("781f1e8a-24a5-435c-a8cb-8d66b4d8495e")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("3f4d335a-41a1-45ee-a024-773504bf88f9"),
            TagId = Guid.Parse("781f1e8a-24a5-435c-a8cb-8d66b4d8495e")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("8e41d5d1-c96d-4971-bfd0-d7ce1f05eae7"),
            TagId = Guid.Parse("781f1e8a-24a5-435c-a8cb-8d66b4d8495e")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("c7f26ca2-536e-4d5d-b656-bef531500957"),
            TagId = Guid.Parse("781f1e8a-24a5-435c-a8cb-8d66b4d8495e")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("b5fadc05-70d1-48f6-bed3-f11b99941e53"),
            TagId = Guid.Parse("781f1e8a-24a5-435c-a8cb-8d66b4d8495e")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("2aa28b07-02db-42d7-a6a7-151b8ceded5d"),
            TagId = Guid.Parse("781f1e8a-24a5-435c-a8cb-8d66b4d8495e")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("6fdc4be8-0dd7-43c7-b617-a14784edd7fe"),
            TagId = Guid.Parse("781f1e8a-24a5-435c-a8cb-8d66b4d8495e")
        },

        // Asian
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("ad82e403-47f2-4844-81da-479e70e4f750"),
            TagId = Guid.Parse("67fd736c-ac11-4c07-a8e8-7da245828866")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("aed8c187-3fab-4703-9091-bbe500cd2404"),
            TagId = Guid.Parse("67fd736c-ac11-4c07-a8e8-7da245828866")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("6db12951-7f53-4f81-b99e-91b7adf74d2e"),
            TagId = Guid.Parse("67fd736c-ac11-4c07-a8e8-7da245828866")
        },

        // Japanese
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("9b9392dc-927e-48b9-87db-8d9a8b0bcf33"),
            TagId = Guid.Parse("b2d0f3ab-8f52-4a63-8fdd-b0f7a6e89c3d")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("096dcfab-16d2-4b75-ae6d-2073ea43a425"),
            TagId = Guid.Parse("b2d0f3ab-8f52-4a63-8fdd-b0f7a6e89c3d")
        },

        // Egyptian
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("f23ddf95-e03e-474e-9a10-1d9f48ccd979"),
            TagId = Guid.Parse("90dbff82-1720-44fa-a9ea-b109a4dc7831")
        },
        new GlimpseHasTag
        {
            GlimpseId = Guid.Parse("f0eede5f-29b3-4c3a-8047-9773fd326535"),
            TagId = Guid.Parse("90dbff82-1720-44fa-a9ea-b109a4dc7831")
        }
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GlimpseHasTag>().HasData(Data);
    }
}