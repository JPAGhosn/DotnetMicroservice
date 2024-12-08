using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Shared.Extensions;

public static class AppSettingsExtension
{
    public static void SetupAppSettings(this IConfigurationBuilder configuration, IWebHostEnvironment environment)
    {
        configuration
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false, true)
            .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", true, true)
            .AddEnvironmentVariables();
    }
}