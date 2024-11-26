using System.ComponentModel.DataAnnotations;
using KRK_Shared.Models;

namespace Reactions.Models;

public class ReactionModel : BaseModel
{
    [Required] public string Name { get; set; }

    public List<ItemHasReaction> ItemHasReactions { get; set; }
}