using System.Text.Json.Serialization;

namespace KRK_Auth.Models;

public class SignInKeycloakResponse
{
    public string access_token { get; set; }
    public string refresh_token { get; set; }
    public string token_type { get; set; }
    public int expires_in { get; set; }
    public int refresh_expires_in { get; set; }
    public string session_state { get; set; }
    public string scope { get; set; }

    [JsonPropertyName("not-before-policy")]
    public int not_before_policy { get; set; }
}