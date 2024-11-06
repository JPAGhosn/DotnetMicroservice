using KRK_Auth.Clients;
using KRK_Auth.Data;
using KRK_Auth.Models;
using KRK_Auth.Responses;

namespace KRK_Auth.Endpoints;

public static class AuthenticationEndpoint
{
    public static void MapAuthEndpoints(this WebApplication app)
    {
        app
            .MapGet("/api/users/check-user-exists/{emailOrPhone}", CheckUserExists)
            .WithName("CheckUserExists")
            .WithOpenApi()
            ;

        app
            .MapPost("/api/auth/sign-in", SignIn)
            .WithName("SignIn")
            .WithOpenApi()
            ;
    }

    private static async Task<IResult> CheckUserExists(string emailOrPhone, AuthDbContext context)
    {
        var user = context.Users.FirstOrDefault(user =>
            user.Email == emailOrPhone || user.PhoneNumber == emailOrPhone);

        var exists = user != null;

        var response = new CheckUserExistsResponse
        {
            Exists = exists
        };

        return Results.Ok(response);
    }

    public static async Task<IResult> SignIn(SignInPayload payload, AuthDbContext context,
        KeycloakClient keycloakClient, CancellationToken cancellationToken)
    {
        // Check if user exists
        var user = context.Users.FirstOrDefault(user =>
            user.Email == payload.emailOrPhone || user.PhoneNumber == payload.emailOrPhone);

        if (user == null)
            return Results.NotFound(new ErrorModel
            {
                Code = "UserNotFound",
                Message = "User not found"
            });

        // Call keycloak to check email and password match
        try
        {
            var signInResponse = await keycloakClient.SignIn(payload.emailOrPhone, payload.password, cancellationToken);
            return Results.Ok(signInResponse);
        }
        catch (Exception ex)
        {
            return Results.Unauthorized();
        }
    }
}