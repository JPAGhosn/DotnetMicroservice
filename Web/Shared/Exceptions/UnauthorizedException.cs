namespace Shared.Exceptions;

public class UnauthorizedException(string? title, string? description) : BaseException(code: 401,
    description: description ?? "Not found",
    title: title ?? "Not found");