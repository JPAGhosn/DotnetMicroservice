using System.ComponentModel.DataAnnotations;
using KRK_Shared.Models;

namespace KRK_Subscriptions.Models;

public class ProfileModel : BaseModel
{
    [MaxLength(48)] public string FirstName { get; set; } = default!;

    [MaxLength(48)] public string LastName { get; set; } = default!;

    [MaxLength(48)] public string UserName { get; set; } = default!;

    [MaxLength(256)] public string ProfilePicture { get; set; } = default!;

    [MaxLength(256)] public string CoverPicture { get; set; } = default!;
}