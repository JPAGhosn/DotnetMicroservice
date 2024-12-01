using KRK_Profiles.Models;
using Microsoft.EntityFrameworkCore;

namespace Profiles.Seeders;

public static class ProfileSeeder
{
    public static List<ProfileModel> Profiles = new()
    {
        // Real
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            FirstName = "Andre",
            LastName = "Rush",
            UserName = "chefrush",
            ProfilePicture = "30f10c25-ab78-452e-82cc-11861c9750a3.jpg",
            CoverPicture = "30f10c25-ab78-452e-82cc-11861c9750a3.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("6b7ffda1-eaab-43bd-b61d-bf0d35766590"),
            FirstName = "Antoine",
            LastName = "El Hajj",
            UserName = "chefantoine",
            ProfilePicture = "6b7ffda1-eaab-43bd-b61d-bf0d35766590.jpg",
            CoverPicture = "6b7ffda1-eaab-43bd-b61d-bf0d35766590.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("f15ee0e3-ee98-474f-b08d-a96d42b76dc4"),
            FirstName = "Yannick",
            LastName = "Alléno",
            UserName = "yannickalleno",
            ProfilePicture = "f15ee0e3-ee98-474f-b08d-a96d42b76dc4.jpg",
            CoverPicture = "f15ee0e3-ee98-474f-b08d-a96d42b76dc4.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("18590908-6512-4948-95ca-14ebb9b75652"),
            FirstName = "Paik",
            LastName = "Jong-won",
            UserName = "paikjongwon",
            ProfilePicture = "18590908-6512-4948-95ca-14ebb9b75652.jpg",
            CoverPicture = "18590908-6512-4948-95ca-14ebb9b75652.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("ebf82549-cfeb-4f3f-a753-21dfcc0ccb61"),
            FirstName = "Ching",
            LastName = "He Huang",
            UserName = "chinghehuang",
            ProfilePicture = "ebf82549-cfeb-4f3f-a753-21dfcc0ccb61.jpg",
            CoverPicture = "ebf82549-cfeb-4f3f-a753-21dfcc0ccb61.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("bd0f2bb7-001b-4990-a15d-48959bfd66dc"),
            FirstName = "Gordon",
            LastName = "Ramsey",
            UserName = "gordonramsey",
            ProfilePicture = "bd0f2bb7-001b-4990-a15d-48959bfd66dc.jpg",
            CoverPicture = "bd0f2bb7-001b-4990-a15d-48959bfd66dc.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("9bbbd1a5-6e07-4e82-998a-7376b3d65909"),
            FirstName = "Natsuko",
            LastName = "Shoji",
            UserName = "natsukoshoji",
            ProfilePicture = "9bbbd1a5-6e07-4e82-998a-7376b3d65909.jpg",
            CoverPicture = "9bbbd1a5-6e07-4e82-998a-7376b3d65909.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("0fe05ee0-1254-4217-ad9b-9b8c8ba2bf46"),
            FirstName = "Abdel-Samea Mohamed Ali",
            LastName = "El-Sherbini",
            UserName = "mohamedalielsherbini",
            ProfilePicture = "0fe05ee0-1254-4217-ad9b-9b8c8ba2bf46.jpg",
            CoverPicture = "0fe05ee0-1254-4217-ad9b-9b8c8ba2bf46.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("9952a929-6005-4e2f-860c-f0e018dbcd89"),
            FirstName = "Marcela",
            LastName = "Valladolid",
            UserName = "marcelavalladolid",
            ProfilePicture = "9952a929-6005-4e2f-860c-f0e018dbcd89.jpg",
            CoverPicture = "9952a929-6005-4e2f-860c-f0e018dbcd89.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("0ec74399-11e5-4d26-b21c-8666caa884a7"),
            FirstName = "Micha",
            LastName = "Fenianos",
            UserName = "michafenianos",
            ProfilePicture = "0ec74399-11e5-4d26-b21c-8666caa884a7.jpg",
            CoverPicture = "0ec74399-11e5-4d26-b21c-8666caa884a7.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("d946ee8d-2797-40ed-8130-f83207158e1c"),
            FirstName = "Manon",
            LastName = "Lagreve",
            UserName = "manonlagreve",
            ProfilePicture = "d946ee8d-2797-40ed-8130-f83207158e1c.jpg",
            CoverPicture = "d946ee8d-2797-40ed-8130-f83207158e1c.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("b1c3b501-4b61-4c23-89de-6745d1044f13"),
            FirstName = "Kim",
            LastName = "Cook",
            UserName = "_cookim_",
            ProfilePicture = "b1c3b501-4b61-4c23-89de-6745d1044f13.jpg",
            CoverPicture = "b1c3b501-4b61-4c23-89de-6745d1044f13.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("902612bf-823f-40b0-9247-7a0a9aa7c6a6"),
            FirstName = "Arthur",
            LastName = "Koumi",
            UserName = "foodiechina888",
            ProfilePicture = "902612bf-823f-40b0-9247-7a0a9aa7c6a6.jpg",
            CoverPicture = "902612bf-823f-40b0-9247-7a0a9aa7c6a6.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("b49c5523-117e-4666-8f3b-ca5bd96f2ede"),
            FirstName = "Megan",
            LastName = "Frost",
            UserName = "takestwoeggs",
            ProfilePicture = "b49c5523-117e-4666-8f3b-ca5bd96f2ede.jpg",
            CoverPicture = "b49c5523-117e-4666-8f3b-ca5bd96f2ede.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("4d4aba40-d0c3-4cdf-9d86-10a92c08b8a2"),
            FirstName = "Maria",
            LastName = "Origami",
            UserName = "bookofdishes",
            ProfilePicture = "4d4aba40-d0c3-4cdf-9d86-10a92c08b8a2.jpg",
            CoverPicture = "4d4aba40-d0c3-4cdf-9d86-10a92c08b8a2.jpeg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("34814847-360e-439e-83cf-d8ee775f547d"),
            FirstName = "Jean Paul",
            LastName = "Abi Ghosn",
            UserName = "jeanpaulabighosn",
            ProfilePicture = "34814847-360e-439e-83cf-d8ee775f547d.jpg",
            CoverPicture = "34814847-360e-439e-83cf-d8ee775f547d.jpeg"
        },

        // Fake
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a4"),
            FirstName = "Mia",
            LastName = "Malkova",
            UserName = "miamalkova",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Ariana",
            LastName = "Marie",
            UserName = "arianamarie",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a6"),
            FirstName = "Olivia",
            LastName = "Austin",
            UserName = "oliviaaustin",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a7"),
            FirstName = "Eva",
            LastName = "Angelina",
            UserName = "evaangelina",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a8"),
            FirstName = "Abella",
            LastName = "Danger",
            UserName = "abelladanger",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a9"),
            FirstName = "Lana",
            LastName = "Rhoades",
            UserName = "lanarhoades",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("40f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Riley",
            LastName = "Reid",
            UserName = "rileyreid",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("50f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Eva",
            LastName = "Elfie",
            UserName = "evaelfie",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("60f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Emily",
            LastName = "Willis",
            UserName = "emilywillis",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("70f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Lena",
            LastName = "Paul",
            UserName = "lenapaul",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("80f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Serenity",
            LastName = "Cox",
            UserName = "serenitycox",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("90f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Adriana",
            LastName = "Chechik",
            UserName = "adrianachechik",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f20c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Dani",
            LastName = "Daniels",
            UserName = "danidaniels",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f40c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Ava",
            LastName = "Addams",
            UserName = "avamaddams"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f50c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Lexi",
            LastName = "Bells",
            UserName = "lexibells",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        }
    };


    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProfileModel>().HasData(Profiles);
    }
}