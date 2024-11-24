namespace Collections.Models;

public class RecipeModel
{
    public Guid Id { get; set; }
    public Guid ExternalId { get; set; }

    public List<CollectionModel> Collections { get; set; }

    public List<CollectionHasRecipe> CollectionHasRecipe { get; set; }
}