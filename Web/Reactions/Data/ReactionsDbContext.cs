using Microsoft.EntityFrameworkCore;
using Reactions.Models;
using Reactions.ModelsConfigurations;
using Reactions.Seeders;

namespace Reactions.Data;

public class ReactionsDbContext(DbContextOptions<ReactionsDbContext> options) : DbContext(options)
{
    public DbSet<ReactionModel> Reactions { get; set; }
    public DbSet<ItemHasReaction> ItemsHasReactions { get; set; }
    public DbSet<ItemTypeModel> ItemTypes { get; set; }
    public DbSet<ItemHasReactionCount> ItemHasReactionCounts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ReactionModelConfiguration());
        modelBuilder.ApplyConfiguration(new ItemTypeModelConfiguration());
        modelBuilder.ApplyConfiguration(new ItemHasReactionConfiguration());
        modelBuilder.ApplyConfiguration(new ItemHasReactionCountConfiguration());

        ReactionSeeder.Seed(modelBuilder);
        ItemTypeSeeder.Seed(modelBuilder);
        ItemsHasReactionsSeeder.Seed(modelBuilder);
        ItemHasReactionCountSeeder.Seed(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }
}