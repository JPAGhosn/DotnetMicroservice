using System.Security.Claims;

namespace KRK_Shared.Helpers;

public static class ClaimsHelper
{
    public static Guid? GetUserId(this ClaimsPrincipal principal)
    {
        var userIdString = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userIdString == null) return null;

        return Guid.Parse(userIdString);
    }
}