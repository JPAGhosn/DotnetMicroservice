using System.ComponentModel.DataAnnotations.Schema;
using KRK_Shared.Models;

namespace KRK_Subscriptions.Models;

public class SubscriptionModel : BaseModel
{
    public Guid ProfileId { get; set; }

    [NotMapped] public ProfileModel? Profile { get; set; }
}