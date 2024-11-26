using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reactions.Models;

namespace Reactions.ModelsConfigurations;

public class ItemHasReactionConfiguration : IEntityTypeConfiguration<ItemHasReaction>
{
    public void Configure(EntityTypeBuilder<ItemHasReaction> builder)
    {
        builder.HasKey(itemHasReaction =>
            new
            {
                itemHasReaction.ItemId, itemHasReaction.ReactionId, itemHasReaction.ItemTypeId,
                itemHasReaction.ProfileId
            });
    }
}