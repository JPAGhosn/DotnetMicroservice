using System.ComponentModel.DataAnnotations;

namespace Reactions.Models;

public class ItemHasReactionCount
{
    [Required] public Guid ReactionId { get; set; }
    public ReactionModel Reaction { get; set; }

    [Required] public Guid ItemTypeId { get; set; }
    public ItemTypeModel ItemType { get; set; }

    [Required] public Guid ItemId { get; set; }

    [Required] public ulong Count { get; set; } = 0;
}