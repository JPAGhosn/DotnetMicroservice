namespace KRK_Auth.Models;

public class SignInPayload
{
    public string EmailOrPhone { get; set; }
    public string Password { get; set; }
}