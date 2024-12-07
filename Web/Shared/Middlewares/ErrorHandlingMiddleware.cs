using KRK_Shared.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Shared.Middlewares;

// Handle dotnet built in errors like Routes not found, ...
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

        if (context.Response.StatusCode == StatusCodes.Status401Unauthorized)
            await ProcessErrorResponse(context, "Unauthorized access", "The requested resource cannot be accessed.",
                "UnauthorizedAccess", StatusCodes.Status401Unauthorized);

        // Handle routes unknown error
        // Check if the response is a 404 and hasn't started yet
        else if (context.Response.StatusCode == StatusCodes.Status404NotFound && !context.Response.HasStarted)
            await ProcessErrorResponse(context, "Route Not Found", "The requested route could not be found.",
                "RouteNotFound", StatusCodes.Status404NotFound);

        // Handles Models not found errors
        else if (context.Response.StatusCode == StatusCodes.Status404NotFound)
            await ProcessErrorResponse(context, "Resource Not Found", "The requested resource could not be found.",
                "ResourceNotFound", StatusCodes.Status404NotFound);

        // Catch unexpected errors
        else if (context.Response.StatusCode == StatusCodes.Status500InternalServerError)
            await ProcessErrorResponse(context, "Resource Not Found", "The requested resource could not be found.",
                "ResourceNotFound", StatusCodes.Status404NotFound);
    }

    private async Task ProcessErrorResponse(HttpContext context, string title, string description, string code,
        int statusCode)
    {
        var error = new BaseError
        {
            Title = title,
            Description = description,
            Code = code
        };

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = statusCode;
        await context.Response.WriteAsync(JsonConvert.SerializeObject(error));
    }
}