using KRK_Shared.Models;

namespace KRK_Subscriptions.Models;

public class SubscriptionModel : BaseModel
{
    public Guid ProfileId { get; set; }

    public ProfileModel? Profile { get; set; }
}