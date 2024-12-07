using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace KRK_Shared.Extensions;

public static class CorsExtension
{
    public static void AddWebCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("Web", policyBuilder =>
            {
                policyBuilder
                    .WithOrigins("http://localhost:4200", "https://kurkle.com")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials()
                    ;
            });
        });
    }

    public static void UseWebCors(this IApplicationBuilder app)
    {
        app.UseCors("Web");
    }
}