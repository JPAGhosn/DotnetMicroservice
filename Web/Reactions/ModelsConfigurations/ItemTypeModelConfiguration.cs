using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reactions.Models;

namespace Reactions.ModelsConfigurations;

public class ItemTypeModelConfiguration : IEntityTypeConfiguration<ItemTypeModel>
{
    public void Configure(EntityTypeBuilder<ItemTypeModel> builder)
    {
        builder
            .HasMany(type => type.ItemHasReaction)
            .WithOne(itemHasReaction => itemHasReaction.ItemType)
            .HasForeignKey(itemHasReaction => itemHasReaction.ItemTypeId);
    }
}