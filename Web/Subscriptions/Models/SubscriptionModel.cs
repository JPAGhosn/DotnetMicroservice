using System.ComponentModel.DataAnnotations.Schema;
using KRK_Shared.Models;

namespace KRK_Subscriptions.Models;

public class SubscriptionModel : BaseModel
{
    public Guid ProfileId { get; set; }

    [NotMapped] public string FirstName { get; set; } = default!;

    [NotMapped] public string LastName { get; set; } = default!;

    [NotMapped] public string UserName { get; set; } = default!;

    [NotMapped] public string? ProfilePicture { get; set; } = default!;

    [NotMapped] public string? CoverPicture { get; set; } = default!;
}