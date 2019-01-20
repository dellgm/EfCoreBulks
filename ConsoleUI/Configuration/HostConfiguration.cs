using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace ConsoleUI.Configuration
{
    public static class HostConfiguration
    {
        public static IHostBuilder ConfigureHost(this IHostBuilder builder, string[] args)
        {
            builder.ConfigureHostConfiguration(configHost =>
            {
                configHost.SetBasePath(Directory.GetCurrentDirectory());
                configHost.AddJsonFile("hostsettings.json", optional: false);
                configHost.AddEnvironmentVariables(prefix: "PREFIX_");
                configHost.AddCommandLine(args);
            });

            return builder;
        }
    }
}
