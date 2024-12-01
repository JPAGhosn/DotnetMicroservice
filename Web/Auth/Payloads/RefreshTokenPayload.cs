using System.ComponentModel.DataAnnotations;

namespace Auth.Payloads;

public class RefreshTokenPayload
{
    [Required] public string RefreshToken { get; set; }
}