namespace KRK_Auth.Models;

public class UserModel
{
    public Guid Id { get; set; }

    public String? FirstName { get; set; }

    public String? LastName { get; set; }

    public String? Email { get; set; }

    public String? PhoneNumber { get; set; }
}