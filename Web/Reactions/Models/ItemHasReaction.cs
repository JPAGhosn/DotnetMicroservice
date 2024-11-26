using System.ComponentModel.DataAnnotations;

namespace Reactions.Models;

public class ItemHasReaction
{
    [Required] public Guid ItemId { get; set; }

    [Required] public Guid ReactionId { get; set; }
    public ReactionModel Reaction { get; set; }

    [Required] public Guid ItemTypeId { get; set; }
    public ItemTypeModel ItemType { get; set; }

    public Guid ProfileId { get; set; }
}