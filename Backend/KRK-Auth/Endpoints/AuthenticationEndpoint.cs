using KRK_Auth.Data;
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
}