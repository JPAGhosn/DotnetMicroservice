using KRK_Subscriptions.Models;
using Microsoft.EntityFrameworkCore;

namespace KRK_Subscriptions.Seeders;

public static class SubscriptionsSeeder
{
    public static readonly List<SubscriptionModel> Subscriptions =
    [
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a3")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a4")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a5")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a6")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a7")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a8")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("30f10c25-ab78-452e-82cc-11861c9750a9")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("30f20c25-ab78-452e-82cc-11861c9750a5")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("30f40c25-ab78-452e-82cc-11861c9750a5")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("30f50c25-ab78-452e-82cc-11861c9750a5")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("50f10c25-ab78-452e-82cc-11861c9750a5")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("60f10c25-ab78-452e-82cc-11861c9750a5")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("70f10c25-ab78-452e-82cc-11861c9750a5")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("80f10c25-ab78-452e-82cc-11861c9750a5")
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProfileId = Guid.Parse("90f10c25-ab78-452e-82cc-11861c9750a5")
        }
    ];

    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SubscriptionModel>().HasData(Subscriptions);
    }
}