namespace Collections.Models.Pivots;

public class CollectionHasRecipe
{
    public Guid CollectionId { get; set; }
    public CollectionModel Collection { get; set; }

    public Guid RecipeId { get; set; }
    public RecipeModel Recipe { get; set; }
}