using Glimpses.Models.Pivots;
using KRK_Shared.Models;

namespace Glimpses.Models;

public class TagModel : BaseModel
{
    public Guid Id { get; set; }

    public Guid ExternalId { get; set; }

    public List<GlimpseModel> Glimpses { get; set; }

    public List<GlimpseHasTag> GlimpseHasTag { get; set; }
}