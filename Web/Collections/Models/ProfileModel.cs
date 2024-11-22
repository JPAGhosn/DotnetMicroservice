namespace Collections.Models;

public class ProfileModel
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = default!;

    public string LastName { get; set; } = default!;

    public string UserName { get; set; } = default!;

    public string? ProfilePicture { get; set; }

    public string? CoverPicture { get; set; }
}