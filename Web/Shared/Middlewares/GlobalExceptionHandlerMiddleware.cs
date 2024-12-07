using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Shared.Exceptions;

namespace Shared.Middlewares;

// Handle thrown exceptions by me
public class GlobalExceptionHandlerMiddleware(RequestDelegate next, IWebHostEnvironment env)
{
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (NotFoundException error)
        {
            await ProcessError(context, error, StatusCodes.Status404NotFound);
        }
        catch (UnauthorizedException error)
        {
            await ProcessError(context, error, StatusCodes.Status401Unauthorized);
        }
        catch (Exception err)
        {
            var error = new BaseException(
                "An unexpected error occured.",
                StatusCodes.Status500InternalServerError,
                "Unexpected error");

            // Do not let the user see the error
            if (env.IsProduction())
                await ProcessError(context,
                    error,
                    StatusCodes.Status500InternalServerError);
            else throw;
        }
    }

    private async Task ProcessError(HttpContext context, BaseException error, int code)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = code;
        var serializerSettings = new JsonSerializerSettings();
        serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

        // Created a new object to prevent showing Exception props
        await context.Response.WriteAsync(JsonConvert.SerializeObject(new
        {
            error.Description,
            error.Code,
            error.Title
        }, serializerSettings));
    }
}