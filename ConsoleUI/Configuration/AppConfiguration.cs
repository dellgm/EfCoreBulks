using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.Configuration
{
    public static class AppConfiguration
    {
        public static IHostBuilder ConfigureApp(this IHostBuilder builder, string[] args)
        {
            builder.ConfigureAppConfiguration((hostContext, configApp) =>
            {
                configApp.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                configApp.AddJsonFile(
                    $"appsettings.{hostContext.HostingEnvironment.EnvironmentName}.json",
                    optional: false, reloadOnChange: true);
                configApp.AddEnvironmentVariables();

                if (args != null)
                {
                    configApp.AddCommandLine(args);
                }
            });

            return builder;
        }
    }
}
