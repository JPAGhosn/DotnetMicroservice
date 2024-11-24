using Collections.Models.Pivots;
using KRK_Shared.Models;

namespace Collections.Models;

public class TagModel : BaseModel
{
    public Guid Id { get; set; }

    public Guid ExternalId { get; set; }

    public List<CollectionModel> Collections { get; set; }

    public List<CollectionHasTag> CollectionHasTag { get; set; }
}