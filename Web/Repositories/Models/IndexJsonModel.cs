namespace Repositories.Models;

public class IndexJsonModel
{
    public RecipeModel Recipe { get; set; }
}

public class RecipeModel
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string? Cover { get; set; }
}