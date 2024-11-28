using System.ComponentModel.DataAnnotations;

namespace Auth.Payloads;

public class SignUpPayload
{
    [Required] [EmailAddress] public string EmailOrPhone { get; set; }

    [Required] public string Password { get; set; }

    [Required] public string FirstName { get; set; }

    [Required] public string LastName { get; set; }
}