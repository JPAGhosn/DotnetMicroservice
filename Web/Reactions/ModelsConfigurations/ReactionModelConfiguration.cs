using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reactions.Models;

namespace Reactions.ModelsConfigurations;

public class ReactionModelConfiguration : IEntityTypeConfiguration<ReactionModel>
{
    public void Configure(EntityTypeBuilder<ReactionModel> builder)
    {
        builder
            .HasMany(m => m.ItemHasReactions)
            .WithOne(m => m.Reaction)
            .HasForeignKey(itemHasReaction => itemHasReaction.ReactionId);
    }
}