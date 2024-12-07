namespace Shared.Exceptions;

public class NotFoundException(string? title, string? description) : BaseException(code: 404,
    description: description ?? "Not found",
    title: title ?? "Not found");