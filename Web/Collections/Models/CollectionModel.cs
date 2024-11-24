using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Collections.Models.Pivots;
using KRK_Shared.Models;

namespace Collections.Models;

public class CollectionModel : BaseModel
{
    [Required] public string Name { get; set; }

    public string? CoverPath1 { get; set; }
    public string? CoverPath2 { get; set; }
    public string? CoverPath3 { get; set; }

    [Required] public Guid CreatorId { get; set; }

    [NotMapped] public ProfileModel? Creator { get; set; }

    [Required] public ulong NumberOfFollowers { get; set; }

    [Required] public DateTime PublishedDate { get; set; }

    public List<RecipeModel> Recipes { get; set; }

    public List<CollectionHasRecipe> CollectionHasRecipe { get; set; }

    public List<TagModel> Tags { get; set; }

    public List<CollectionHasTag> CollectionHasTag { get; set; }
}