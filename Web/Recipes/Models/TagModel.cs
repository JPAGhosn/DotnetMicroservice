using KRK_Shared.Models;
using Recipes.Models.Pivots;

namespace Recipes.Models;

public class TagModel : BaseModel
{
    public Guid Id { get; set; }

    public Guid ExternalId { get; set; }

    public List<RecipeModel> Recipes { get; set; }

    public List<RecipeHasTag> RecipeHasTag { get; set; }
}