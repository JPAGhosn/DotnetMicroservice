using KRK_Shared.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace KRK_Shared.Middlewares;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        await _next(context);

        if (context.Response.StatusCode == StatusCodes.Status404NotFound)
        {
            var error = new BaseError
            {
                Title = "Resource Not Found",
                Description = "The requested resource could not be found.",
                Code = "404"
            };

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status404NotFound;
            await context.Response.WriteAsync(JsonConvert.SerializeObject(error));
        }
    }
}