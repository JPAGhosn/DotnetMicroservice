using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KRK_Shared.Models;

namespace Recipes.Models;

public class RecipeModel
{
    [Key] public Guid Id { get; set; }

    [Required] public string Name { get; set; }

    public string? Cover { get; set; }

    [Required] public Guid CreatorId { get; set; }

    [NotMapped] public ProfileModel Creator { get; set; }

    [Required] public int NumberOfViews { get; set; } = 0;

    [Required] public DateTime PublishedDate { get; set; } = DateTime.Now;
}