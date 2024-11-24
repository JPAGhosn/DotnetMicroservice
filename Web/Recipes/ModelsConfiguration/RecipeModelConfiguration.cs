using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Models;
using Recipes.Models.Pivots;

namespace Recipes.ModelsConfiguration;

public class RecipeModelConfiguration : IEntityTypeConfiguration<RecipeModel>
{
    public void Configure(EntityTypeBuilder<RecipeModel> builder)
    {
        builder
            .HasMany(recipe => recipe.Tags)
            .WithMany(tag => tag.Recipes)
            .UsingEntity<RecipeHasTag>(
                b => b
                    .HasOne(recipeHasTag => recipeHasTag.Tag)
                    .WithMany(tag => tag.RecipeHasTag)
                    .HasForeignKey(recipeHasTag => recipeHasTag.TagId),
                b => b
                    .HasOne(recipeHasTag => recipeHasTag.Recipe)
                    .WithMany(recipe => recipe.RecipeHasTag)
                    .HasForeignKey(recipeHasTag => recipeHasTag.RecipeId),
                jointEntity =>
                {
                    jointEntity.HasKey(recipeHasTag => new
                    {
                        recipeHasTag.RecipeId,
                        recipeHasTag.TagId
                    });
                }
            );
    }
}