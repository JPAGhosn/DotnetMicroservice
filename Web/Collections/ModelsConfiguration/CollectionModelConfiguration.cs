using Collections.Models;
using Collections.Models.Pivots;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Collections.ModelsConfiguration;

public class CollectionModelConfiguration : IEntityTypeConfiguration<CollectionModel>
{
    public void Configure(EntityTypeBuilder<CollectionModel> builder)
    {
        // CollectionHasRecipe
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

        // CollectionHasTag
        builder
            .HasMany(recipe => recipe.Tags)
            .WithMany(tag => tag.Collections)
            .UsingEntity<CollectionHasTag>(
                b => b
                    .HasOne(recipeHasTag => recipeHasTag.Tag)
                    .WithMany(tag => tag.CollectionHasTag)
                    .HasForeignKey(recipeHasTag => recipeHasTag.TagId),
                b => b
                    .HasOne(recipeHasTag => recipeHasTag.Collection)
                    .WithMany(recipe => recipe.CollectionHasTag)
                    .HasForeignKey(recipeHasTag => recipeHasTag.CollectionId),
                jointEntity =>
                {
                    jointEntity.HasKey(recipeHasTag => new
                    {
                        recipeHasTag.CollectionId,
                        recipeHasTag.TagId
                    });
                }
            );
    }
}