using Collections.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Collections.ModelsConfiguration;

public class CollectionModelConfiguration : IEntityTypeConfiguration<CollectionModel>
{
    public void Configure(EntityTypeBuilder<CollectionModel> builder)
    {
        builder
            .HasMany(collection => collection.Recipes)
            .WithMany(recipe => recipe.Collections)
            .UsingEntity<CollectionHasRecipe>(
                builder => builder
                    .HasOne(collectionHasRecipe => collectionHasRecipe.Recipe)
                    .WithMany(recipe => recipe.CollectionHasRecipe)
                    .HasForeignKey(collectionHasRecipe => collectionHasRecipe.RecipeId),
                builder => builder
                    .HasOne(collectionHasRecipe => collectionHasRecipe.Collection)
                    .WithMany(collection => collection.CollectionHasRecipe)
                    .HasForeignKey(collectionHasRecipe => collectionHasRecipe.CollectionId),
                jointEntity =>
                {
                    jointEntity.HasKey(collectionHasRecipe => new
                    {
                        collectionHasRecipe.RecipeId,
                        collectionHasRecipe.CollectionId
                    });
                }
            );
    }
}