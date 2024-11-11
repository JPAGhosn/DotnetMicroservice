namespace KRK_Auth.Bindings;

public class KeycloakOptions
{
    public string Url { get; set; }
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string Realm { get; set; }
}