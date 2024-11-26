using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reactions.Models;

namespace Reactions.ModelsConfigurations;

public class ItemHasReactionCountConfiguration : IEntityTypeConfiguration<ItemHasReactionCount>
{
    public void Configure(EntityTypeBuilder<ItemHasReactionCount> builder)
    {
        builder
            .HasKey(itemHasReactionCount => new
                { itemHasReactionCount.ItemId, itemHasReactionCount.ReactionId, itemHasReactionCount.ItemTypeId });
    }
}