using Recipes.Models;

namespace Recipes.Dtos.Recipe;

public class RecipeViewDto
{
    public RecipeViewDto(RecipeModel recipe)
    {
        Id = recipe.Id;
        Name = recipe.Name;
        Creator = recipe.Creator;
        Cover = recipe.Cover;
        NumberOfViews = recipe.NumberOfViews;
        PublishedDate = recipe.PublishedDate;
    }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public string? Cover { get; set; }

    public ProfileModel Creator { get; set; }

    public int NumberOfViews { get; set; }

    public DateTime PublishedDate { get; set; } = DateTime.Now;
}