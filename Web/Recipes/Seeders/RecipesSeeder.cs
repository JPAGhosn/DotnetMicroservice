using Microsoft.EntityFrameworkCore;
using Recipes.Models;

namespace Recipes.Seeders;

public static class RecipesSeeder
{
    public static List<RecipeModel> Recipes = new()
    {
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Hamburger American Style",
            NumberOfViews = 0,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Pizza De La Mama",
            NumberOfViews = 33,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Mjadara A La Libanaise",
            NumberOfViews = 4232,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Arnabit A La Libanaise",
            NumberOfViews = 2988,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken Wings",
            NumberOfViews = 45324,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Subway Sandwich",
            NumberOfViews = 65345,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Grilled Chicken",
            NumberOfViews = 176543,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Cajun Chicken",
            NumberOfViews = 356734,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Mighty Chicken",
            NumberOfViews = 12987,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "1.jpg"
        },

        // Additional 50 RecipeModel instances
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Spaghetti Carbonara",
            NumberOfViews = 1500,
            PublishedDate = DateTime.Parse("2020-10-01 09:30:00").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef Stroganoff",
            NumberOfViews = 2450,
            PublishedDate = DateTime.Parse("2020-10-02 11:45:00").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable Stir Fry",
            NumberOfViews = 980,
            PublishedDate = DateTime.Parse("2020-10-03 14:20:00").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Lemon Garlic Salmon",
            NumberOfViews = 3120,
            PublishedDate = DateTime.Parse("2020-10-04 16:50:00").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Thai Green Curry",
            NumberOfViews = 2765,
            PublishedDate = DateTime.Parse("2020-10-05 13:15:00").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef Tacos",
            NumberOfViews = 1987,
            PublishedDate = DateTime.Parse("2020-10-06 12:00:00").ToUniversalTime(),
            Cover = "1.jpg"
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken Alfredo",
            NumberOfViews = 3421,
            PublishedDate = DateTime.Parse("2020-10-07 17:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Quinoa Salad",
            NumberOfViews = 875,
            PublishedDate = DateTime.Parse("2020-10-08 08:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Shrimp Scampi",
            NumberOfViews = 2900,
            PublishedDate = DateTime.Parse("2020-10-09 19:10:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "BBQ Ribs",
            NumberOfViews = 4105,
            PublishedDate = DateTime.Parse("2020-10-10 15:25:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Veggie Lasagna",
            NumberOfViews = 1320,
            PublishedDate = DateTime.Parse("2020-10-11 10:40:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Fish and Chips",
            NumberOfViews = 2530,
            PublishedDate = DateTime.Parse("2020-10-12 18:55:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Butter Chicken",
            NumberOfViews = 3780,
            PublishedDate = DateTime.Parse("2020-10-13 14:05:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Falafel Wrap",
            NumberOfViews = 1625,
            PublishedDate = DateTime.Parse("2020-10-14 09:50:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef Bourguignon",
            NumberOfViews = 2975,
            PublishedDate = DateTime.Parse("2020-10-15 20:20:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Pancakes with Maple Syrup",
            NumberOfViews = 450,
            PublishedDate = DateTime.Parse("2020-10-16 07:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Eggplant Parmesan",
            NumberOfViews = 2100,
            PublishedDate = DateTime.Parse("2020-10-17 12:35:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken Teriyaki",
            NumberOfViews = 3650,
            PublishedDate = DateTime.Parse("2020-10-18 16:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Broccoli",
            NumberOfViews = 2890,
            PublishedDate = DateTime.Parse("2020-10-19 13:55:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Stuffed Bell Peppers",
            NumberOfViews = 1340,
            PublishedDate = DateTime.Parse("2020-10-20 11:10:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Shrimp Tacos",
            NumberOfViews = 3100,
            PublishedDate = DateTime.Parse("2020-10-21 18:25:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken Quesadillas",
            NumberOfViews = 2750,
            PublishedDate = DateTime.Parse("2020-10-22 14:40:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable Paella",
            NumberOfViews = 980,
            PublishedDate = DateTime.Parse("2020-10-23 09:55:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Lamb Kebabs",
            NumberOfViews = 3200,
            PublishedDate = DateTime.Parse("2020-10-24 20:10:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Mushroom Risotto",
            NumberOfViews = 1505,
            PublishedDate = DateTime.Parse("2020-10-25 07:20:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef Enchiladas",
            NumberOfViews = 2895,
            PublishedDate = DateTime.Parse("2020-10-26 12:35:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Butternut Squash Soup",
            NumberOfViews = 1230,
            PublishedDate = DateTime.Parse("2020-10-27 10:50:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Pesto Pasta",
            NumberOfViews = 2140,
            PublishedDate = DateTime.Parse("2020-10-28 15:05:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken Biryani",
            NumberOfViews = 3340,
            PublishedDate = DateTime.Parse("2020-10-29 19:20:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Tuna Casserole",
            NumberOfViews = 1780,
            PublishedDate = DateTime.Parse("2020-10-30 08:35:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Pulled Pork Sandwiches",
            NumberOfViews = 4200,
            PublishedDate = DateTime.Parse("2020-10-31 17:50:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Greek Salad",
            NumberOfViews = 980,
            PublishedDate = DateTime.Parse("2020-11-01 09:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Turkey Meatloaf",
            NumberOfViews = 2550,
            PublishedDate = DateTime.Parse("2020-11-02 14:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable Curry",
            NumberOfViews = 1900,
            PublishedDate = DateTime.Parse("2020-11-03 11:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Sausage and Peppers",
            NumberOfViews = 3100,
            PublishedDate = DateTime.Parse("2020-11-04 16:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Ratatouille",
            NumberOfViews = 1420,
            PublishedDate = DateTime.Parse("2020-11-05 10:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken Piccata",
            NumberOfViews = 3250,
            PublishedDate = DateTime.Parse("2020-11-06 18:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Baked Ziti",
            NumberOfViews = 2675,
            PublishedDate = DateTime.Parse("2020-11-07 13:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Stuffed Chicken Breast",
            NumberOfViews = 1980,
            PublishedDate = DateTime.Parse("2020-11-08 15:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef Burritos",
            NumberOfViews = 3050,
            PublishedDate = DateTime.Parse("2020-11-09 19:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Sweet and Sour Pork",
            NumberOfViews = 2780,
            PublishedDate = DateTime.Parse("2020-11-10 12:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken Caesar Salad",
            NumberOfViews = 2200,
            PublishedDate = DateTime.Parse("2020-11-11 09:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef Wellington",
            NumberOfViews = 3600,
            PublishedDate = DateTime.Parse("2020-11-12 17:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Lentil Soup",
            NumberOfViews = 1400,
            PublishedDate = DateTime.Parse("2020-11-13 08:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Garlic Shrimp",
            NumberOfViews = 2750,
            PublishedDate = DateTime.Parse("2020-11-14 14:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Baked Salmon",
            NumberOfViews = 3100,
            PublishedDate = DateTime.Parse("2020-11-15 19:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Pork Schnitzel",
            NumberOfViews = 1950,
            PublishedDate = DateTime.Parse("2020-11-16 11:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken Tikka Masala",
            NumberOfViews = 3400,
            PublishedDate = DateTime.Parse("2020-11-17 16:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef Chili",
            NumberOfViews = 2850,
            PublishedDate = DateTime.Parse("2020-11-18 13:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Caprese Salad",
            NumberOfViews = 1200,
            PublishedDate = DateTime.Parse("2020-11-19 10:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken Fajitas",
            NumberOfViews = 3300,
            PublishedDate = DateTime.Parse("2020-11-20 18:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Bean Stew",
            NumberOfViews = 2600,
            PublishedDate = DateTime.Parse("2020-11-21 14:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable Lasagna",
            NumberOfViews = 1600,
            PublishedDate = DateTime.Parse("2020-11-22 09:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Honey Glazed Ham",
            NumberOfViews = 2950,
            PublishedDate = DateTime.Parse("2020-11-23 20:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef Tostadas",
            NumberOfViews = 2100,
            PublishedDate = DateTime.Parse("2020-11-24 07:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Pumpkin Soup",
            NumberOfViews = 1350,
            PublishedDate = DateTime.Parse("2020-11-25 12:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Teriyaki Beef Bowl",
            NumberOfViews = 3450,
            PublishedDate = DateTime.Parse("2020-11-26 16:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable Stir Fry with Tofu",
            NumberOfViews = 1750,
            PublishedDate = DateTime.Parse("2020-11-27 10:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken Marsala",
            NumberOfViews = 3150,
            PublishedDate = DateTime.Parse("2020-11-28 19:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Stir Fry",
            NumberOfViews = 2800,
            PublishedDate = DateTime.Parse("2020-11-29 14:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Pork Carnitas",
            NumberOfViews = 2300,
            PublishedDate = DateTime.Parse("2020-11-30 09:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Shrimp Fried Rice",
            NumberOfViews = 2950,
            PublishedDate = DateTime.Parse("2020-12-01 17:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken Noodle Soup",
            NumberOfViews = 1850,
            PublishedDate = DateTime.Parse("2020-12-02 12:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef Pho",
            NumberOfViews = 3100,
            PublishedDate = DateTime.Parse("2020-12-03 20:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Dumplings",
            NumberOfViews = 2250,
            PublishedDate = DateTime.Parse("2020-12-04 07:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef Tacos Al Pastor",
            NumberOfViews = 3400,
            PublishedDate = DateTime.Parse("2020-12-05 13:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable Tempura",
            NumberOfViews = 1600,
            PublishedDate = DateTime.Parse("2020-12-06 09:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef Satay",
            NumberOfViews = 3050,
            PublishedDate = DateTime.Parse("2020-12-07 18:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken Parmesan",
            NumberOfViews = 2900,
            PublishedDate = DateTime.Parse("2020-12-08 14:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Mushroom Pie",
            NumberOfViews = 2600,
            PublishedDate = DateTime.Parse("2020-12-09 10:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Rice Casserole",
            NumberOfViews = 2400,
            PublishedDate = DateTime.Parse("2020-12-10 19:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef Burrito Bowl",
            NumberOfViews = 3250,
            PublishedDate = DateTime.Parse("2020-12-11 15:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable Frittata",
            NumberOfViews = 1550,
            PublishedDate = DateTime.Parse("2020-12-12 08:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Spinach Lasagna",
            NumberOfViews = 2800,
            PublishedDate = DateTime.Parse("2020-12-13 12:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Broccoli Alfredo",
            NumberOfViews = 3100,
            PublishedDate = DateTime.Parse("2020-12-14 17:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Bean Chili",
            NumberOfViews = 2950,
            PublishedDate = DateTime.Parse("2020-12-15 14:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable Stir Fry with Noodles",
            NumberOfViews = 1700,
            PublishedDate = DateTime.Parse("2020-12-16 10:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Kebabs",
            NumberOfViews = 3150,
            PublishedDate = DateTime.Parse("2020-12-17 19:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken Cacciatore",
            NumberOfViews = 3000,
            PublishedDate = DateTime.Parse("2020-12-18 15:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Bean Enchiladas",
            NumberOfViews = 2700,
            PublishedDate = DateTime.Parse("2020-12-19 11:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Mushroom Stroganoff",
            NumberOfViews = 2450,
            PublishedDate = DateTime.Parse("2020-12-20 20:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Potato Stew",
            NumberOfViews = 2900,
            PublishedDate = DateTime.Parse("2020-12-21 16:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable Quiche",
            NumberOfViews = 1500,
            PublishedDate = DateTime.Parse("2020-12-22 09:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Kabobs",
            NumberOfViews = 3200,
            PublishedDate = DateTime.Parse("2020-12-23 13:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Spinach Pasta",
            NumberOfViews = 2750,
            PublishedDate = DateTime.Parse("2020-12-24 18:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Fajitas",
            NumberOfViews = 3050,
            PublishedDate = DateTime.Parse("2020-12-25 14:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable Biryani",
            NumberOfViews = 1650,
            PublishedDate = DateTime.Parse("2020-12-26 10:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Bean Nachos",
            NumberOfViews = 3150,
            PublishedDate = DateTime.Parse("2020-12-27 19:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Broccoli Stir Fry",
            NumberOfViews = 2900,
            PublishedDate = DateTime.Parse("2020-12-28 15:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Stew",
            NumberOfViews = 2800,
            PublishedDate = DateTime.Parse("2020-12-29 11:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Pork and Vegetable Stir Fry",
            NumberOfViews = 2350,
            PublishedDate = DateTime.Parse("2020-12-30 20:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Vegetable Curry",
            NumberOfViews = 3000,
            PublishedDate = DateTime.Parse("2020-12-31 16:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Lasagna",
            NumberOfViews = 2750,
            PublishedDate = DateTime.Parse("2021-01-01 12:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable and Tofu Stir Fry",
            NumberOfViews = 1800,
            PublishedDate = DateTime.Parse("2021-01-02 09:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Tacos",
            NumberOfViews = 3300,
            PublishedDate = DateTime.Parse("2021-01-03 18:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Vegetable Stir Fry",
            NumberOfViews = 2950,
            PublishedDate = DateTime.Parse("2021-01-04 14:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable and Beef Stir Fry",
            NumberOfViews = 2000,
            PublishedDate = DateTime.Parse("2021-01-05 10:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Fettuccine",
            NumberOfViews = 3100,
            PublishedDate = DateTime.Parse("2021-01-06 19:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Vegetable Stew",
            NumberOfViews = 2850,
            PublishedDate = DateTime.Parse("2021-01-07 15:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Risotto",
            NumberOfViews = 2750,
            PublishedDate = DateTime.Parse("2021-01-08 11:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable and Beef Stir Fry with Rice",
            NumberOfViews = 2450,
            PublishedDate = DateTime.Parse("2021-01-09 20:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Pasta",
            NumberOfViews = 3000,
            PublishedDate = DateTime.Parse("2021-01-10 16:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable and Chicken Alfredo",
            NumberOfViews = 1600,
            PublishedDate = DateTime.Parse("2021-01-11 09:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Paella",
            NumberOfViews = 3250,
            PublishedDate = DateTime.Parse("2021-01-12 13:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Vegetable Jambalaya",
            NumberOfViews = 2750,
            PublishedDate = DateTime.Parse("2021-01-13 18:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Goulash",
            NumberOfViews = 3050,
            PublishedDate = DateTime.Parse("2021-01-14 14:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable and Beef Stew",
            NumberOfViews = 2000,
            PublishedDate = DateTime.Parse("2021-01-15 10:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Casserole",
            NumberOfViews = 3150,
            PublishedDate = DateTime.Parse("2021-01-16 19:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Vegetable Biryani",
            NumberOfViews = 2950,
            PublishedDate = DateTime.Parse("2021-01-17 15:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Stir Fry with Noodles",
            NumberOfViews = 2850,
            PublishedDate = DateTime.Parse("2021-01-18 11:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable and Beef Pasta",
            NumberOfViews = 2400,
            PublishedDate = DateTime.Parse("2021-01-19 20:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Alfredo",
            NumberOfViews = 3000,
            PublishedDate = DateTime.Parse("2021-01-20 16:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable and Beef Fettuccine",
            NumberOfViews = 1650,
            PublishedDate = DateTime.Parse("2021-01-21 09:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Lasagna",
            NumberOfViews = 3250,
            PublishedDate = DateTime.Parse("2021-01-22 13:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Vegetable Alfredo",
            NumberOfViews = 2750,
            PublishedDate = DateTime.Parse("2021-01-23 18:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Stir Fry",
            NumberOfViews = 3050,
            PublishedDate = DateTime.Parse("2021-01-24 14:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegetable and Beef Risotto",
            NumberOfViews = 2000,
            PublishedDate = DateTime.Parse("2021-01-25 10:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Casserole",
            NumberOfViews = 3150,
            PublishedDate = DateTime.Parse("2021-01-26 19:30:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Vegetable Biryani",
            NumberOfViews = 2950,
            PublishedDate = DateTime.Parse("2021-01-27 15:45:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Beef and Vegetable Stir Fry with Noodles",
            NumberOfViews = 2850,
            PublishedDate = DateTime.Parse("2021-01-28 11:00:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Pork and Vegetable Stir Fry",
            NumberOfViews = 2350,
            PublishedDate = DateTime.Parse("2021-01-29 20:15:00").ToUniversalTime()
        },
        new RecipeModel
        {
            Id = Guid.NewGuid(),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chicken and Vegetable Curry",
            NumberOfViews = 3000,
            PublishedDate = DateTime.Parse("2021-01-30 16:30:00").ToUniversalTime()
        }
    };

    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeModel>().HasData(Recipes);
    }
}