using KRK_Shared.Models;

namespace Reactions.Models;

public class ItemTypeModel : BaseModel
{
    public string Name { get; set; }

    public List<ItemHasReaction> ItemHasReaction { get; set; }
}