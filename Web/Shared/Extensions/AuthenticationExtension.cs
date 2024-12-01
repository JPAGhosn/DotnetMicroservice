using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace KRK_Shared.Extensions;

public static class AuthenticationExtension
{
    public static void SetupAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        var jwtSettings = configuration.GetSection("JwtSettings");

        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.Authority = configuration["JwtSettings:Authority"];
                options.Audience = configuration["JwtSettings:Audience"];
                options.RequireHttpsMetadata = configuration.GetValue<bool>("JwtSettings:RequireHttpsMetadata");

                // Optional: Customize token validation parameters
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = configuration["JwtSettings:Authority"],
                    ValidateAudience = true,
                    ValidAudience = configuration["JwtSettings:Audience"],
                    ValidateLifetime = true
                };
            });

        // Add authorization services and policies
        services.AddAuthorization();
    }

    public static void SetupAuthentication(this IApplicationBuilder app, IConfiguration configuration)
    {
        app.UseAuthentication();
        app.UseAuthorization();
    }
}