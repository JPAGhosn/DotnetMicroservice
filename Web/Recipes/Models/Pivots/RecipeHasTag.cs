namespace Recipes.Models.Pivots;

public class RecipeHasTag
{
    public Guid RecipeId { get; set; }
    public RecipeModel Recipe { get; set; }

    public Guid TagId { get; set; }
    public TagModel Tag { get; set; }
}