using Glimpses.Models;
using Microsoft.EntityFrameworkCore;

namespace Glimpses.Seeders;

public static class GlimpsesSeeder
{
    public static List<GlimpseModel> Data = new()
    {
        new GlimpseModel
        {
            Id = Guid.Parse("7e2381b5-20fb-439a-9321-f7ba3c897e25"),
            VideoPath = "7e2381b5-20fb-439a-9321-f7ba3c897e25.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3")
        },
        new GlimpseModel
        {
            Id = Guid.Parse("281a72e1-8e0f-4d15-8dd7-07ae79b46521"),
            VideoPath = "281a72e1-8e0f-4d15-8dd7-07ae79b46521.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3")
        },
        new GlimpseModel
        {
            Id = Guid.Parse("c256956f-a969-4062-b58c-8a84d50bb375"),
            VideoPath = "c256956f-a969-4062-b58c-8a84d50bb375.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3")
        },
        new GlimpseModel
        {
            Id = Guid.Parse("c9ecce38-494d-4d86-b39c-e6d8b3a174eb"),
            VideoPath = "c9ecce38-494d-4d86-b39c-e6d8b3a174eb.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3")
        },
        new GlimpseModel
        {
            Id = Guid.Parse("c0b10a81-0657-4c35-9a9a-31ecb50a7db5"),
            VideoPath = "c0b10a81-0657-4c35-9a9a-31ecb50a7db5.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3")
        },
        new GlimpseModel
        {
            Id = Guid.Parse("46b8c61e-fdc9-442e-81f9-1a30fd191075"),
            VideoPath = "46b8c61e-fdc9-442e-81f9-1a30fd191075.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3")
        },
        new GlimpseModel
        {
            Id = Guid.Parse("bd0dac86-3da6-43d5-9070-847a72f00bfc"),
            VideoPath = "bd0dac86-3da6-43d5-9070-847a72f00bfc.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3")
        },
        new GlimpseModel
        {
            Id = Guid.Parse("5af9d3d4-fc51-49e5-9988-71fd5a185b04"),
            VideoPath = "5af9d3d4-fc51-49e5-9988-71fd5a185b04.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3")
        },
        new GlimpseModel
        {
            Id = Guid.Parse("ab0cf111-2091-4524-bb3f-17f5391ad435"),
            VideoPath = "ab0cf111-2091-4524-bb3f-17f5391ad435.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3")
        },
        new GlimpseModel
        {
            Id = Guid.Parse("c5aa62bc-cb06-4e63-9000-2d1ffd0dddb3"),
            VideoPath = "c5aa62bc-cb06-4e63-9000-2d1ffd0dddb3.mp4",
            CreatorId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3")
        }
    };

    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<GlimpseModel>().HasData(Data);
    }
}