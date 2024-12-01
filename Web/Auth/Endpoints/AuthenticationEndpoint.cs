using Auth.Data;
using Auth.Payloads;
using KRK_Auth.Clients;
using KRK_Auth.Models;
using KRK_Auth.Responses;
using KRK_Shared.Helpers;
using KRK_Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KRK_Auth.Endpoints;

public static class AuthenticationEndpoint
{
    public static void MapAuthEndpoints(this WebApplication app)
    {
        app
            .MapGet("/api/auth/users/check-user-exists/{emailOrPhone}", CheckUserExists)
            .WithName("CheckUserExists")
            .WithOpenApi()
            ;

        app
            .MapPost("/api/auth/sign-in", SignIn)
            .WithName("SignIn")
            .WithOpenApi()
            ;

        app.MapPost("/api/auth/refresh-token", RefreshToken);

        app
            .MapPost("/api/auth/sign-up", SignUp);

        app
            .MapGet("/api/auth/reset-password", () => { });

        app
            .MapGet("/api/auth/confirm-account", () => { });

        app
            .MapGet("/api/auth/request-reset-password", () => { });
    }

    private static async Task<IResult> RefreshToken(HttpContext httpContext, RefreshTokenPayload payload,
        KeycloakClient keycloakClient, CancellationToken cancellationToken)
    {
        var tokens = await keycloakClient.RefreshToken(payload.RefreshToken, cancellationToken);

        return Results.Ok(tokens);
    }

    private static async Task<IResult> SignUp([FromBody] SignUpPayload payload, AuthDbContext context,
        KeycloakClient keycloakClient,
        CancellationToken cancellationToken)
    {
        // check if user exists
        var user = await context.Users.FirstOrDefaultAsync(u => u.Email == payload.EmailOrPhone, cancellationToken);
        if (user != null)
            return Results.BadRequest(new BaseError
            {
                Code = "UserAlreadyExists",
                Title = "User already exists",
                Description = "User already exists"
            });

        // Check if exists in keycloak db
        var exists = await keycloakClient.CheckUserExists(payload.EmailOrPhone, cancellationToken);
        if (exists)
            return Results.BadRequest(new BaseError
            {
                Code = "UserAlreadyExists",
                Title = "User already exists",
                Description = "User already exists"
            });

        // Create a new user in keycloak
        await keycloakClient.CreateUser(payload, cancellationToken);

        // Sign in to get the id of the user in keycloak and use it in the db
        try
        {
            var keycloakUser = await keycloakClient.SignIn(payload.EmailOrPhone, payload.Password, cancellationToken);

            // Decode the access token to get the id
            var id = JwtHelper.GetIdFromToken(keycloakUser.access_token);

            // Create a user in our database
            user = new UserModel
            {
                Id = Guid.Parse(id),
                FirstName = payload.FirstName,
                LastName = payload.LastName,
                Email = payload.EmailOrPhone,
                PhoneNumber = null
            };
            await context.Users.AddAsync(user, cancellationToken);

            return Results.Ok(new
            {
                User = user,
                Authentication = keycloakUser
            });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Results.BadRequest(new BaseError
            {
                Code = "Unauthorized",
                Title = "Unauthorized access",
                Description = "unauthorized access"
            });
        }
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
            user.Email == payload.EmailOrPhone || user.PhoneNumber == payload.EmailOrPhone);

        if (user == null)
            return Results.NotFound(new ErrorModel
            {
                Code = "UserNotFound",
                Message = "User not found"
            });

        // Call keycloak to check email and password match
        try
        {
            var signInResponse = await keycloakClient.SignIn(payload.EmailOrPhone, payload.Password, cancellationToken);
            return Results.Ok(signInResponse);
        }
        catch (Exception ex)
        {
            return Results.Unauthorized();
        }
    }
}