using KRK_Profiles.Models;
using Microsoft.EntityFrameworkCore;

namespace KRK_Profiles.Seeders;

public static class ProfileSeeder
{
    public static List<ProfileModel> Profiles = new()
    {
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            FirstName = "Mia",
            LastName = "Khalifa",
            UserName = "miakhalifa",
            ProfilePicture = "MainBefore.jpg",
            CoverPicture = "MainBefore.jpg"
        },
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