namespace KRK_Auth.Models;

public class SignInPayload
{
    public string emailOrPhone { get; set; }
    public string password { get; set; }
}