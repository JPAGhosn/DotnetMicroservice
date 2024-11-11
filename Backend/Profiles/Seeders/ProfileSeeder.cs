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
            UserName = "miakhalifa"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a4"),
            FirstName = "Mia",
            LastName = "Malkova",
            UserName = "miamalkova"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Ariana",
            LastName = "Marie",
            UserName = "arianamarie"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a6"),
            FirstName = "Olivia",
            LastName = "Austin",
            UserName = "oliviaaustin"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a7"),
            FirstName = "Eva",
            LastName = "Angelina",
            UserName = "evaangelina"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a8"),
            FirstName = "Abella",
            LastName = "Danger",
            UserName = "abelladanger"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a9"),
            FirstName = "Lana",
            LastName = "Rhoades",
            UserName = "lanarhoades"
        },
        new ProfileModel
        {
            Id = Guid.Parse("40f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Riley",
            LastName = "Reid",
            UserName = "rileyreid"
        },
        new ProfileModel
        {
            Id = Guid.Parse("50f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Eva",
            LastName = "Elfie",
            UserName = "evaelfie"
        },
        new ProfileModel
        {
            Id = Guid.Parse("60f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Emily",
            LastName = "Willis",
            UserName = "emilywillis"
        },
        new ProfileModel
        {
            Id = Guid.Parse("70f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Lena",
            LastName = "Paul",
            UserName = "lenapaul"
        },
        new ProfileModel
        {
            Id = Guid.Parse("80f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Serenity",
            LastName = "Cox",
            UserName = "serenitycox"
        },
        new ProfileModel
        {
            Id = Guid.Parse("90f10c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Adriana",
            LastName = "Chechik",
            UserName = "adrianachechik"
        },
        new ProfileModel
        {
            Id = Guid.Parse("30f20c25-ab78-452e-82cc-11861c9750a5"),
            FirstName = "Dani",
            LastName = "Daniels",
            UserName = "danidaniels"
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
            UserName = "lexibells"
        }
    };


    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProfileModel>().HasData(Profiles);
    }
}