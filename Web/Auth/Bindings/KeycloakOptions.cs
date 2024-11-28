namespace KRK_Auth.Bindings;

public class KeycloakOptions
{
    public string Url { get; set; }
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string Realm { get; set; }
    public string AdminUsername { get; set; }
    public string AdminPassword { get; set; }
    public string AdminClientId { get; set; }
}