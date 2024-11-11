using KRK_Subscriptions.Models;
using KRK_Subscriptions.Seeders;
using Microsoft.EntityFrameworkCore;

namespace KRK_Subscriptions.Data;

public class SubscriptionsDbContext : DbContext
{
    public SubscriptionsDbContext(DbContextOptions<SubscriptionsDbContext> options) : base(options)
    {
    }

    public DbSet<SubscriptionModel> Subscriptions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();

        base.OnModelCreating(modelBuilder);
    }
}