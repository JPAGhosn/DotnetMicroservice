using System.IdentityModel.Tokens.Jwt;

namespace KRK_Shared.Helpers;

public class JwtHelper
{
    public static string GetIdFromToken(string token)
    {
        var handler = new JwtSecurityTokenHandler();
        var jwtToken = handler.ReadJwtToken(token);

        // Extract the "id" claim
        return jwtToken.Claims.FirstOrDefault(c => c.Type == "sub")!.Value;
    }
}