namespace Shared.Exceptions;

public class BaseException : Exception
{
    public BaseException(string description, int code, string title)
    {
        Description = description;
        Code = code;
        Title = title;
    }

    public string Description { get; set; }

    public int Code { get; set; }

    public string Title { get; set; }
}