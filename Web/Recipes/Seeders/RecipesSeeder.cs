using Microsoft.EntityFrameworkCore;
using Recipes.Models;

namespace Recipes.Seeders;

public static class RecipesSeeder
{
    public static List<RecipeModel> Recipes = new()
    {
        new RecipeModel
        {
            Id = Guid.Parse("9ecd7941-eafd-4b6a-b129-f3808c3d9bfc"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Basic Sabzee (Curried Vegetables)",
            NumberOfViews = 434434,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "9ecd7941-eafd-4b6a-b129-f3808c3d9bfc.png",
            Slug = "basic-sabzee"
        },
        new RecipeModel
        {
            Id = Guid.Parse("7f407a72-ba91-4851-9c59-ceeb069b8454"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Mango Lassi",
            NumberOfViews = 433,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "7f407a72-ba91-4851-9c59-ceeb069b8454.png",
            Slug = "mango-lassi"
        },
        new RecipeModel
        {
            Id = Guid.Parse("74061819-d8f0-4220-8a2e-f423064b9596"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Golden Milk: Healing Tonic for Vitality and Flexibility",
            NumberOfViews = 3232,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "74061819-d8f0-4220-8a2e-f423064b9596.png",
            Slug = "golden-milk"
        },
        new RecipeModel
        {
            Id = Guid.Parse("ec5361cc-1935-4ece-8ee4-1dc8b828c59e"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Solstice Potato Soup",
            NumberOfViews = 323212,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "ec5361cc-1935-4ece-8ee4-1dc8b828c59e.png",
            Slug = "soltice-potato-soup"
        },
        new RecipeModel
        {
            Id = Guid.Parse("2df0deca-8b7e-4a92-8fdb-54dd99cb120b"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Hearty & Delicious Potato Leek Soup",
            NumberOfViews = 65654,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "2df0deca-8b7e-4a92-8fdb-54dd99cb120b.png",
            Slug = "hearty-and-delicious-potato-leek-soup"
        },
        new RecipeModel
        {
            Id = Guid.Parse("458b0559-39b2-4c17-8303-464f73aaaa0c"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "3 Bean Vegetarian Chili and Skillet Cornbread",
            NumberOfViews = 435,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "458b0559-39b2-4c17-8303-464f73aaaa0c.png",
            Slug = "3-bean-vegetarian-chili-and-skillet-cornbread"
        },
        new RecipeModel
        {
            Id = Guid.Parse("0195eb1a-96e5-415a-97de-d66e825d499c"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "3 Bean Vegetarian Chili and Skillet Cornbread",
            NumberOfViews = 654,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "0195eb1a-96e5-415a-97de-d66e825d499c.png",
            Slug = "3-bean-vegetarian-chili-and-skillet-cornbread"
        },
        new RecipeModel
        {
            Id = Guid.Parse("a957b032-8508-44f8-9166-b9930eb0a6e7"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Decadent Vegan Chocolate Mousse",
            NumberOfViews = 42342342,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "a957b032-8508-44f8-9166-b9930eb0a6e7.png",
            Slug = "decadent-vegetarian-chocolate-mousse"
        },
        new RecipeModel
        {
            Id = Guid.Parse("ab3ebd2d-f94d-490a-8a19-ff60243b1881"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Easy Triple Berry Galette",
            NumberOfViews = 654675,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "ab3ebd2d-f94d-490a-8a19-ff60243b1881.png",
            Slug = "easy-triple-berry-galette"
        },
        new RecipeModel
        {
            Id = Guid.Parse("ae414607-b268-4a1e-9911-fc70d935fb74"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Spaghetti Squash with Marinara and Parmesan",
            NumberOfViews = 4565456,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "ae414607-b268-4a1e-9911-fc70d935fb74.png",
            Slug = "spaghetti-squash with marinara-and-parmesan"
        },
        new RecipeModel
        {
            Id = Guid.Parse("d8bb1649-2c06-44b9-80e7-c6d7b06c7a34"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Vegan Zuppa Toscana",
            NumberOfViews = 798879,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "d8bb1649-2c06-44b9-80e7-c6d7b06c7a34.png",
            Slug = "vegan-zuppa-toscana"
        },
        new RecipeModel
        {
            Id = Guid.Parse("fd91c5d8-fb87-4d15-8c23-d0d686856588"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "The Best Tofu Scramble",
            NumberOfViews = 33,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "fd91c5d8-fb87-4d15-8c23-d0d686856588.png",
            Slug = "the-best-tofu-scramble"
        },
        new RecipeModel
        {
            Id = Guid.Parse("fcde7ae3-4c40-4cf6-8968-26ea7caf4032"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Grilled Mushroom Steaks with Polenta",
            NumberOfViews = 5342,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "fcde7ae3-4c40-4cf6-8968-26ea7caf4032.png",
            Slug = "grilled-mushroom-steaks-with-polenta"
        },
        new RecipeModel
        {
            Id = Guid.Parse("1e7acbcb-a575-4511-ae19-b5971177a15c"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Basmati Rice with Garlic and Parsley",
            NumberOfViews = 33,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "1e7acbcb-a575-4511-ae19-b5971177a15c.png",
            Slug = "basmati-rice-with-parsley"
        },
        new RecipeModel
        {
            Id = Guid.Parse("5ca82ead-9965-4963-aea5-20e1a2f5bb29"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Hot Chapattis: Spicy Corn & Garbanzo Fritters",
            NumberOfViews = 68898,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "5ca82ead-9965-4963-aea5-20e1a2f5bb29.png",
            Slug = "hottchapattis-spicy-corn"
        },
        new RecipeModel
        {
            Id = Guid.Parse("6235f110-a0b5-4f79-8333-5e1a39c6eee5"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Fall Yoga Bowl",
            NumberOfViews = 987867,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "6235f110-a0b5-4f79-8333-5e1a39c6eee5.png",
            Slug = "fall-yoga-bowl"
        },
        new RecipeModel
        {
            Id = Guid.Parse("ecbaaa43-9d1b-4a62-8226-068ff320906e"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Grilled Portobello Mushroom Burgers",
            NumberOfViews = 3423432432,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "ecbaaa43-9d1b-4a62-8226-068ff320906e.png",
            Slug = "grilled-portobello-burger"
        },
        new RecipeModel
        {
            Id = Guid.Parse("a7064206-50a7-458d-b420-38e03c37fe42"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Best Black Bean Veggie Burgers",
            NumberOfViews = 3234454355653,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "a7064206-50a7-458d-b420-38e03c37fe42.png",
            Slug = "best-black-bean-veggie-burger"
        },
        new RecipeModel
        {
            Id = Guid.Parse("9a215ebc-3d48-40ee-9537-462cf603dbbe"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Easy Weeknight Ramen Noodles",
            NumberOfViews = 42345434435,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "9a215ebc-3d48-40ee-9537-462cf603dbbe.png",
            Slug = "easy-weeknight-ramen-noodles"
        },
        new RecipeModel
        {
            Id = Guid.Parse("273a52af-fe96-4edf-8c93-f95676e53f8d"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Tofu, Lentil, and Quinoa Bowl",
            NumberOfViews = 534543,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "273a52af-fe96-4edf-8c93-f95676e53f8d.png",
            Slug = "tofu-lentil-ramen-noodles"
        },
        new RecipeModel
        {
            Id = Guid.Parse("78b5e258-bef9-4af6-ae38-66990afd3268"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Banana Whey Smoothie for Children",
            NumberOfViews = 4343,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "78b5e258-bef9-4af6-ae38-66990afd3268.png",
            Slug = "banana-whey-smoothie-for-children"
        },
        new RecipeModel
        {
            Id = Guid.Parse("fc6610da-2751-4b1c-b929-dfde52049e54"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Cleansing Beet Millet Pancakes",
            NumberOfViews = 232423,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "fc6610da-2751-4b1c-b929-dfde52049e54.png",
            Slug = "cleansing-beet-millet-pancakes"
        },
        new RecipeModel
        {
            Id = Guid.Parse("dcb00c6a-f3fd-41de-8455-fef6aaf836da"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Potent Potato Soup",
            NumberOfViews = 4234,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "dcb00c6a-f3fd-41de-8455-fef6aaf836da.png",
            Slug = "potato-soup"
        },
        new RecipeModel
        {
            Id = Guid.Parse("523ffde2-cbde-48fd-947f-5d935a025ba7"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Your Choice Muffins",
            NumberOfViews = 0,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "523ffde2-cbde-48fd-947f-5d935a025ba7.png",
            Slug = "your-choice-muffins"
        },
        new RecipeModel
        {
            Id = Guid.Parse("026d3f56-9e23-4fa6-a7b4-32dd2bca860b"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Root Vegetable Curry Soup",
            NumberOfViews = 43543534,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "026d3f56-9e23-4fa6-a7b4-32dd2bca860b.png",
            Slug = "root-vegetable-curry-soup"
        },
        new RecipeModel
        {
            Id = Guid.Parse("1924c6ca-e6e4-4fe7-9e13-840c2627f6c9"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Fountain of Youth Fruit Salad",
            NumberOfViews = 0,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "1924c6ca-e6e4-4fe7-9e13-840c2627f6c9.png",
            Slug = "fountain-of-youth-fruitsalad"
        },
        new RecipeModel
        {
            Id = Guid.Parse("a541ce68-3834-4c18-96a2-8e7bf0afe3a1"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Mineral-Balancing Cilantro, Celery, and Tahini Dressing",
            NumberOfViews = 6756,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "a541ce68-3834-4c18-96a2-8e7bf0afe3a1.png",
            Slug = "mineral-balancing-cilantro"
        },
        new RecipeModel
        {
            Id = Guid.Parse("b45c6b09-803d-42a5-a8c5-4efd0a8cbdc4"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Chocolate Bliss Balls",
            NumberOfViews = 5675643,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "b45c6b09-803d-42a5-a8c5-4efd0a8cbdc4.png",
            Slug = "chocolate-bliss-balls"
        },
        new RecipeModel
        {
            Id = Guid.Parse("ad42d148-6771-48f5-a152-f01bab953f73"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Blissful Cacao Smoothie",
            NumberOfViews = 5345454,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "ad42d148-6771-48f5-a152-f01bab953f73.png",
            Slug = "blissful-cacao-smoothie"
        },
        new RecipeModel
        {
            Id = Guid.Parse("c9e46e37-fb57-42d3-8b4d-b3d66eaf016e"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Swiss Chard & Rose Potatoes with Mustard Oil",
            NumberOfViews = 5435465,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "c9e46e37-fb57-42d3-8b4d-b3d66eaf016e.png",
            Slug = "swiss-chard-potatoes"
        },
        new RecipeModel
        {
            Id = Guid.Parse("cd94a6a4-957e-4062-a9d9-6f68c1395f29"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Spaghetti Squash with Turmeric",
            NumberOfViews = 876,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "cd94a6a4-957e-4062-a9d9-6f68c1395f29.png",
            Slug = "spaghetti-squash"
        },
        new RecipeModel
        {
            Id = Guid.Parse("4c59dbf9-5e17-4886-a026-fb674273a775"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Ginger Curry",
            NumberOfViews = 232343,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "4c59dbf9-5e17-4886-a026-fb674273a775.png",
            Slug = "ginger-curry"
        },
        new RecipeModel
        {
            Id = Guid.Parse("6bb57dc9-8d9a-4bc0-a957-ffc4bec1b018"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Jalapeno Pancakes",
            NumberOfViews = 564655,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "6bb57dc9-8d9a-4bc0-a957-ffc4bec1b018.png",
            Slug = "jalapeno-pancakes"
        },
        new RecipeModel
        {
            Id = Guid.Parse("5c6d4a87-cbbe-41e6-823c-f6352d5c6292"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Ms. Whiz: The Perfect Breakfast Drink for Women",
            NumberOfViews = 786,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "5c6d4a87-cbbe-41e6-823c-f6352d5c6292.png",
            Slug = "m-woman-drink"
        },
        new RecipeModel
        {
            Id = Guid.Parse("1347c878-fa9a-4031-9d78-04ed25689b08"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Savory Indian Pancakes",
            NumberOfViews = 786567,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "1347c878-fa9a-4031-9d78-04ed25689b08.png",
            Slug = "savory-indian-pancakes"
        },
        new RecipeModel
        {
            Id = Guid.Parse("ee00deba-4a76-40bc-9473-97e9234fc817"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Potent Potatoes",
            NumberOfViews = 0,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "ee00deba-4a76-40bc-9473-97e9234fc817.png",
            Slug = "potent-potatoes"
        },
        new RecipeModel
        {
            Id = Guid.Parse("351b2c40-cce3-4d78-9dfe-fabd38a12911"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Golden Milk: Healing Tonic for Vitality and Flexibility",
            NumberOfViews = 0,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "351b2c40-cce3-4d78-9dfe-fabd38a12911.png",
            Slug = "golden-milk"
        },
        new RecipeModel
        {
            Id = Guid.Parse("dc8d6830-2dd5-4455-9c04-65990d120abd"),
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3"),
            Name = "Healing Ginger Lemon Drink",
            NumberOfViews = 0,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "dc8d6830-2dd5-4455-9c04-65990d120abd.png",
            Slug = "healing-ginger-lemon-drink"
        },

        // Lebanese
        new RecipeModel
        {
            Id = Guid.Parse("9dae1b65-0507-4625-a64f-8cd375d1034c"),
            CreatorId = Guid.Parse("6b7ffda1-eaab-43bd-b61d-bf0d35766590"),
            Name = "Lebanese Stuffed Grape Leaves",
            NumberOfViews = 434312,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "9dae1b65-0507-4625-a64f-8cd375d1034c.png",
            Slug = "lebanese-stuffed-grape-leaves"
        },
        new RecipeModel
        {
            Id = Guid.Parse("313a8ab8-f2b4-45c3-9dd1-a9498ea94a39"),
            CreatorId = Guid.Parse("6b7ffda1-eaab-43bd-b61d-bf0d35766590"),
            Name = "Fattoush Salad",
            NumberOfViews = 4322,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "313a8ab8-f2b4-45c3-9dd1-a9498ea94a39.png",
            Slug = "fattoush-salad"
        },
        new RecipeModel
        {
            Id = Guid.Parse("88313bf8-1510-4659-b301-e0d1f6629721"),
            CreatorId = Guid.Parse("6b7ffda1-eaab-43bd-b61d-bf0d35766590"),
            Name = "Olive Oil Mashed Potatoes",
            NumberOfViews = 4322,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "88313bf8-1510-4659-b301-e0d1f6629721.png",
            Slug = "olive-oil-mashed-potatoes"
        },
        new RecipeModel
        {
            Id = Guid.Parse("55d9272f-851a-4638-abbb-92b92ccb031e"),
            CreatorId = Guid.Parse("6b7ffda1-eaab-43bd-b61d-bf0d35766590"),
            Name = "Roasted Brussels Sprouts with Toasted Hazelnuts",
            NumberOfViews = 4322,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "55d9272f-851a-4638-abbb-92b92ccb031e.png",
            Slug = "roasted-brussels-sprouts-with-toasted-hazelnuts"
        },

        // French
        new RecipeModel
        {
            Id = Guid.Parse("d7c4877c-bfc3-4519-b21d-f8d01da3d729"),
            CreatorId = Guid.Parse("f15ee0e3-ee98-474f-b08d-a96d42b76dc4"),
            Name = "Stuffed Mushroom Caps with Pork and Brie (Champignons Farcis)",
            NumberOfViews = 32112,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "d7c4877c-bfc3-4519-b21d-f8d01da3d729.png",
            Slug = "stuffed-mushroom-caps-with-pork-and-brie-champions-farcis"
        },
        new RecipeModel
        {
            Id = Guid.Parse("738f7ad7-4060-4a74-bcc7-c29ca4e23ce2"),
            CreatorId = Guid.Parse("f15ee0e3-ee98-474f-b08d-a96d42b76dc4"),
            Name = "Pouding Chômeur (Quebecois Maple Pudding)",
            NumberOfViews = 31232111,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "d7c4877c-bfc3-4519-b21d-f8d01da3d729.png",
            Slug = "pouding-champions-farcis"
        },
        new RecipeModel
        {
            Id = Guid.Parse("c7494117-5946-4efe-a26d-ee3a6d380d15"),
            CreatorId = Guid.Parse("f15ee0e3-ee98-474f-b08d-a96d42b76dc4"),
            Name = "Classic French Onion Soup",
            NumberOfViews = 31232111,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "c7494117-5946-4efe-a26d-ee3a6d380d15.png",
            Slug = "classic-french-onion-soup"
        },
        new RecipeModel
        {
            Id = Guid.Parse("297d7739-22fd-4c59-a8f3-1b0c818a3d9b"),
            CreatorId = Guid.Parse("f15ee0e3-ee98-474f-b08d-a96d42b76dc4"),
            Name = "French Almond Croissants (Bakery Style)",
            NumberOfViews = 21218932121,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "297d7739-22fd-4c59-a8f3-1b0c818a3d9b.png",
            Slug = "french-almond-croissants"
        },

        // Korean
        new RecipeModel
        {
            Id = Guid.Parse("cd63330c-aec2-4cd3-aea7-0fe36694577b"),
            CreatorId = Guid.Parse("18590908-6512-4948-95ca-14ebb9b75652"),
            Name = "Kal Bibimmyeon with Chadolbaegi Salad",
            NumberOfViews = 23323,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "cd63330c-aec2-4cd3-aea7-0fe36694577b.png",
            Slug = "kal-bibimmyeon-salad"
        },
        new RecipeModel
        {
            Id = Guid.Parse("51c48c53-8299-4b52-b581-a38516effb12"),
            CreatorId = Guid.Parse("18590908-6512-4948-95ca-14ebb9b75652"),
            Name = "Korean Style Mala Fried Chicken",
            NumberOfViews = 98292,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "51c48c53-8299-4b52-b581-a38516effb12.png",
            Slug = "korean-style-mala-fried-chicken"
        },
        new RecipeModel
        {
            Id = Guid.Parse("91f71ec1-ec59-4745-93e4-2cebe4bf5d60"),
            CreatorId = Guid.Parse("18590908-6512-4948-95ca-14ebb9b75652"),
            Name = "Kongguksu (Soy Milk Noodle Soup)",
            NumberOfViews = 54652,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "91f71ec1-ec59-4745-93e4-2cebe4bf5d60.png",
            Slug = "kongguksu-soy-milk-noodle-soup"
        },
        new RecipeModel
        {
            Id = Guid.Parse("9fcb71bc-86b2-415c-95df-770651b05e05"),
            CreatorId = Guid.Parse("18590908-6512-4948-95ca-14ebb9b75652"),
            Name = "Korean Acorn Jelly (Dotorimuk Muchim)",
            NumberOfViews = 9875,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "9fcb71bc-86b2-415c-95df-770651b05e05.png",
            Slug = "korean-acorn-jelly-muchim"
        },

        // Asian
        new RecipeModel
        {
            Id = Guid.Parse("3d056e57-6e50-4d83-8ad4-55755849a575"),
            CreatorId = Guid.Parse("ebf82549-cfeb-4f3f-a753-21dfcc0ccb61"),
            Name = "Baked Sweet And Sour Chicken",
            NumberOfViews = 9875,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "3d056e57-6e50-4d83-8ad4-55755849a575.png",
            Slug = "baked-sweet-and-sour-chicken"
        },
        new RecipeModel
        {
            Id = Guid.Parse("193b9092-1f68-45ce-bdb4-1c362c7f50ee"),
            CreatorId = Guid.Parse("ebf82549-cfeb-4f3f-a753-21dfcc0ccb61"),
            Name = "Copycat Panda Express Orange Chicken",
            NumberOfViews = 9875,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "193b9092-1f68-45ce-bdb4-1c362c7f50ee.png",
            Slug = "copycat-panda-express-orange-chicken"
        },
        new RecipeModel
        {
            Id = Guid.Parse("963fbaca-aaaf-4c5d-a88d-b385fb2c80ff"),
            CreatorId = Guid.Parse("ebf82549-cfeb-4f3f-a753-21dfcc0ccb61"),
            Name = "4-Ingredient Orange Chicken",
            NumberOfViews = 9875,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "963fbaca-aaaf-4c5d-a88d-b385fb2c80ff.png",
            Slug = "4-ingredient-orange-chicken"
        },
        new RecipeModel
        {
            Id = Guid.Parse("771c0417-da5e-4901-809d-844fb3abfdd4"),
            CreatorId = Guid.Parse("ebf82549-cfeb-4f3f-a753-21dfcc0ccb61"),
            Name = "Copycat Din Tai Fung Cucumber Salad",
            NumberOfViews = 9875,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "771c0417-da5e-4901-809d-844fb3abfdd4.png",
            Slug = "copycat-din-tai-fung-cucumbersalad"
        },

        // American
        new RecipeModel
        {
            Id = Guid.Parse("8abf601e-4f02-4bc8-9dba-0474723d908c"),
            CreatorId = Guid.Parse("bd0f2bb7-001b-4990-a15d-48959bfd66dc"),
            Name = "Slow-Cooker Brisket",
            NumberOfViews = 323443434,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "8abf601e-4f02-4bc8-9dba-0474723d908c.png",
            Slug = "slow-cooker-brisket"
        },
        new RecipeModel
        {
            Id = Guid.Parse("d4d00bef-c865-495d-8c96-eec230bcf1ac"),
            CreatorId = Guid.Parse("bd0f2bb7-001b-4990-a15d-48959bfd66dc"),
            Name = "Banana Split",
            NumberOfViews = 3245466512,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "d4d00bef-c865-495d-8c96-eec230bcf1ac.png",
            Slug = "banana-split"
        },
        new RecipeModel
        {
            Id = Guid.Parse("10b97e4c-30f2-499d-9f8d-0c0d79af8822"),
            CreatorId = Guid.Parse("bd0f2bb7-001b-4990-a15d-48959bfd66dc"),
            Name = "Wisconsin Butter Burgers",
            NumberOfViews = 3245466512,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "10b97e4c-30f2-499d-9f8d-0c0d79af8822.png",
            Slug = "wisconsin-butter-burgers"
        },
        new RecipeModel
        {
            Id = Guid.Parse("0a59a6e6-a583-417e-81ad-89e7cb55b8f4"),
            CreatorId = Guid.Parse("bd0f2bb7-001b-4990-a15d-48959bfd66dc"),
            Name = "Tater Tot Casserole",
            NumberOfViews = 992328,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "0a59a6e6-a583-417e-81ad-89e7cb55b8f4.png",
            Slug = "tater-tot-casserole"
        },

        // Japanese
        new RecipeModel
        {
            Id = Guid.Parse("d55f4548-c2e6-4816-892e-7f520fbc311b"),
            CreatorId = Guid.Parse("9bbbd1a5-6e07-4e82-998a-7376b3d65909"),
            Name = "Bamboo Shoots Simmered in Bonito Flakes (Takenoko no Tosani)",
            NumberOfViews = 9833,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "d55f4548-c2e6-4816-892e-7f520fbc311b.png",
            Slug = "bamboo-shoots-simmered-in-bonito-flakes"
        },
        new RecipeModel
        {
            Id = Guid.Parse("c7cbd853-5d60-4096-bd82-a33191cdd2ca"),
            CreatorId = Guid.Parse("9bbbd1a5-6e07-4e82-998a-7376b3d65909"),
            Name = "Miso Soup with Kingfish Head (Kingfish Arajiru)",
            NumberOfViews = 992328,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "c7cbd853-5d60-4096-bd82-a33191cdd2ca.png",
            Slug = "miso-soup-with-kingfish-head"
        },
        new RecipeModel
        {
            Id = Guid.Parse("f656c46f-eb2b-4808-93b8-78f8c85ddbe9"),
            CreatorId = Guid.Parse("9bbbd1a5-6e07-4e82-998a-7376b3d65909"),
            Name = "Fried Tofu with Thick Mushroom Sauce (Mushroom Ankake)\n",
            NumberOfViews = 992328,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "f656c46f-eb2b-4808-93b8-78f8c85ddbe9.png",
            Slug = "fried-tofu-with-kingfish-head"
        },

        // Egyptian
        new RecipeModel
        {
            Id = Guid.Parse("2ec1d62e-953f-481a-a1cd-ad145deae37a"),
            CreatorId = Guid.Parse("0fe05ee0-1254-4217-ad9b-9b8c8ba2bf46"),
            Name = "Date Cake",
            NumberOfViews = 7689,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "2ec1d62e-953f-481a-a1cd-ad145deae37a.png",
            Slug = "date-cake"
        },
        new RecipeModel
        {
            Id = Guid.Parse("cded9fee-5057-4b91-9e50-a812248458bd"),
            CreatorId = Guid.Parse("0fe05ee0-1254-4217-ad9b-9b8c8ba2bf46"),
            Name = "Stuffed Roast Duck Recipe",
            NumberOfViews = 565,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "cded9fee-5057-4b91-9e50-a812248458bd.png",
            Slug = "stuffed-roast-duck-recipe"
        },
        new RecipeModel
        {
            Id = Guid.Parse("17d56165-5365-4bf1-80db-3aea91f9d115"),
            CreatorId = Guid.Parse("0fe05ee0-1254-4217-ad9b-9b8c8ba2bf46"),
            Name = "Easy Coconut Macaroons Recipe",
            NumberOfViews = 24334,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "17d56165-5365-4bf1-80db-3aea91f9d115.png",
            Slug = "easy-coconut-macaroons-recipe"
        },
        new RecipeModel
        {
            Id = Guid.Parse("6c3f64a9-750a-4422-aec7-346327e9089d"),
            CreatorId = Guid.Parse("0fe05ee0-1254-4217-ad9b-9b8c8ba2bf46"),
            Name = "Baked Sea Bass",
            NumberOfViews = 97687,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "6c3f64a9-750a-4422-aec7-346327e9089d.png",
            Slug = "baked-sea-bass"
        },

        // Mexican
        new RecipeModel
        {
            Id = Guid.Parse("2bec25d1-0d12-4445-9aee-38b18dc27c41"),
            CreatorId = Guid.Parse("9952a929-6005-4e2f-860c-f0e018dbcd89"),
            Name = "Chicken Chile Verde",
            NumberOfViews = 823292,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "2bec25d1-0d12-4445-9aee-38b18dc27c41.png",
            Slug = "chicken-chile-verde"
        },
        new RecipeModel
        {
            Id = Guid.Parse("02bb5e76-0b06-4d99-b9a9-cef5ee6bb8df"),
            CreatorId = Guid.Parse("9952a929-6005-4e2f-860c-f0e018dbcd89"),
            Name = "Easy Vegetarian Breakfast Burritos",
            NumberOfViews = 823292,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "02bb5e76-0b06-4d99-b9a9-cef5ee6bb8df.png",
            Slug = "easy-vegetarian-burritos"
        },
        new RecipeModel
        {
            Id = Guid.Parse("2769be35-6c35-47cb-8a0d-c7fb68d6cb8b"),
            CreatorId = Guid.Parse("9952a929-6005-4e2f-860c-f0e018dbcd89"),
            Name = "Easy Calabacitas Recipe",
            NumberOfViews = 823292,
            PublishedDate = DateTime.Parse("2020-09-25 10:15:30").ToUniversalTime(),
            Cover = "2769be35-6c35-47cb-8a0d-c7fb68d6cb8b.png",
            Slug = "easy-calabacitas-recipe"
        }
    };

    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeModel>().HasData(Recipes);
    }
}