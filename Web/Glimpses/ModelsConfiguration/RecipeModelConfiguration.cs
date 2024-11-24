using Glimpses.Models;
using Glimpses.Models.Pivots;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Glimpses.ModelsConfiguration;

public class GlimpseModelConfiguration : IEntityTypeConfiguration<GlimpseModel>
{
    public void Configure(EntityTypeBuilder<GlimpseModel> builder)
    {
        builder
            .HasMany(recipe => recipe.Tags)
            .WithMany(tag => tag.Glimpses)
            .UsingEntity<GlimpseHasTag>(
                b => b
                    .HasOne(glimpseHasTag => glimpseHasTag.Tag)
                    .WithMany(tag => tag.GlimpseHasTag)
                    .HasForeignKey(recipeHasTag => recipeHasTag.TagId),
                b => b
                    .HasOne(glimpseHasTag => glimpseHasTag.Glimpse)
                    .WithMany(recipe => recipe.GlimpseHasTag)
                    .HasForeignKey(recipeHasTag => recipeHasTag.GlimpseId),
                jointEntity =>
                {
                    jointEntity.HasKey(recipeHasTag => new
                    {
                        RecipeId = recipeHasTag.GlimpseId,
                        recipeHasTag.TagId
                    });
                }
            );
    }
}