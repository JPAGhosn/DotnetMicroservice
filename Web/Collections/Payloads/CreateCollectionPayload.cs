using System.ComponentModel.DataAnnotations;

namespace Collections.Payloads;

public class CreateCollectionPayload
{
    [Required] public string Name { get; set; }
    [Required] public Guid recipeId { get; set; }
}