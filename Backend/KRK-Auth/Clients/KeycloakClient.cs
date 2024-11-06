using System.Text.Json;
using KRK_Auth.Bindings;
using KRK_Auth.Models;

namespace KRK_Auth.Clients;

public class KeycloakClient(HttpClient httpClient, KeycloakOptions keycloakOptions)
{
    public async Task<SignInKeycloakResponse> SignIn(string emailOrPhone, string password,
        CancellationToken cancellationToken)
    {
        var postData = new List<KeyValuePair<string, string>>
        {
            new("grant_type", "password"),
            new("client_id", keycloakOptions.ClientId),
            new("client_secret", keycloakOptions.ClientSecret),
            new("username", emailOrPhone),
            new("password", password)
        };

        var content = new FormUrlEncodedContent(postData);

        var response = await httpClient.PostAsync(
            $"{keycloakOptions.Url}/realms/{keycloakOptions.Realm}/protocol/openid-connect/token", content,
            cancellationToken);

        response.EnsureSuccessStatusCode();

        if (!response.IsSuccessStatusCode) throw new UnauthorizedAccessException();

        var responseData = await response.Content.ReadAsStringAsync(cancellationToken);
        var result = JsonSerializer.Deserialize<SignInKeycloakResponse>(responseData)!;

        return result;
    }
}