using KRK_Shared.Models;

namespace KRK_Profiles.Models;

public class ProfileModel : BaseModel
{
    public string FirstName { get; set; } = default!;

    public string LastName { get; set; } = default!;

    public string UserName { get; set; } = default!;

    public string? ProfilePicture { get; set; }

    public string? CoverPicture { get; set; }
}