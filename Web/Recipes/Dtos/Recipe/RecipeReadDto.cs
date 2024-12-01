using Recipes.Models;
using Shared.Models;

namespace Recipes.Dtos.Recipe;

public class RecipeReadDto
{
    public RecipeReadDto(RecipeModel recipe)
    {
        Id = recipe.Id;
        Name = recipe.Name;
        Creator = recipe.Creator;
        Cover = recipe.Cover;
        NumberOfViews = recipe.NumberOfViews;
        PublishedDate = recipe.PublishedDate;
        slug = recipe.Slug;
    }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public string? Cover { get; set; }

    public ProfileModel Creator { get; set; }

    public ulong NumberOfViews { get; set; }

    public DateTime PublishedDate { get; set; } = DateTime.Now;

    public string slug { get; set; }
}