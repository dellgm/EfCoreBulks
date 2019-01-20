using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ConsoleUI.Configuration
{
    public static class LogginConfiguration
    {
        public static IHostBuilder ConfigureLogging(this IHostBuilder builder)
        {
            builder.ConfigureLogging((hostContext, logging) =>
            {
                logging.AddConfiguration(hostContext.Configuration.GetSection("Logging"));
                logging.AddConsole();
            });

            return builder;
        }
    }
}
