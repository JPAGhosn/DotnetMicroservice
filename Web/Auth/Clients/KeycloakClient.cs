using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Auth.Payloads;
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

        if (!response.IsSuccessStatusCode) throw new UnauthorizedAccessException();

        var responseData = await response.Content.ReadAsStringAsync(cancellationToken);
        var result = JsonSerializer.Deserialize<SignInKeycloakResponse>(responseData)!;

        return result;
    }

    public async Task<dynamic> CreateUser(SignUpPayload payload, CancellationToken cancellationToken)
    {
        var accessToken = await GetAdminAccessToken(cancellationToken);

        var requestMessage = new HttpRequestMessage(HttpMethod.Post,
            $"{keycloakOptions.Url}/admin/realms/{keycloakOptions.Realm}/users");
        requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

        var data = new
        {
            username = payload.EmailOrPhone,
            email = payload.EmailOrPhone,
            enabled = true,
            emailVerified = true,
            credentials = new[]
            {
                new
                {
                    type = "password",
                    value = payload.Password,
                    temporary = false
                }
            }
        };

        requestMessage.Content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

        var response = await httpClient.SendAsync(requestMessage, cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync(cancellationToken);
            throw new UnauthorizedAccessException($"Request failed with status {response.StatusCode}: {errorContent}");
        }

        return true;
    }

    public async Task<bool> CheckUserExists(string email, CancellationToken cancellationToken)
    {
        var accessToken = await GetAdminAccessToken(cancellationToken);

        var requestMessage =
            new HttpRequestMessage(HttpMethod.Get,
                $"{keycloakOptions.Url}/admin/realms/{keycloakOptions.Realm}/users?email={email}");

        requestMessage.Headers.Authorization =
            new AuthenticationHeaderValue("Bearer", accessToken);

        var response = await httpClient.SendAsync(
            requestMessage,
            cancellationToken);

        if (!response.IsSuccessStatusCode) throw new UnauthorizedAccessException();

        var responseData = await response.Content.ReadAsStringAsync(cancellationToken);

        var result = JsonSerializer.Deserialize<List<dynamic>>(responseData)!;

        return result.Count != 0;
    }

    private async Task<string> GetAdminAccessToken(CancellationToken cancellationToken)
    {
        var postData = new List<KeyValuePair<string, string>>
        {
            new("grant_type", "password"),
            new("client_id", keycloakOptions.AdminClientId),
            new("username", keycloakOptions.AdminUsername),
            new("password", keycloakOptions.AdminPassword)
        };

        var content = new FormUrlEncodedContent(postData);

        var url = $"{keycloakOptions.Url}/realms/master/protocol/openid-connect/token";
        var response = await httpClient.PostAsync(
            url, content,
            cancellationToken);

        response.EnsureSuccessStatusCode();

        if (!response.IsSuccessStatusCode) throw new UnauthorizedAccessException();

        var responseData = await response.Content.ReadAsStringAsync(cancellationToken);

        var result = JsonSerializer.Deserialize<SignInKeycloakResponse>(responseData)!;

        var token = result.access_token;

        return token;
    }
}