using EfCoreBulks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace ConsoleUI.Configuration
{
    public static class ServicesConfiguration
    {
        public static IHostBuilder ConfigureServices(this IHostBuilder builder)
        {
            builder.ConfigureServices((hostContext, services) =>
            {
                if (hostContext.HostingEnvironment.IsDevelopment())
                {
                    // Development service configuration
                }
                else
                {
                    // Non-development service configuration
                }

                services.Configure<HostOptions>(options =>
                {
                    options.ShutdownTimeout = TimeSpan.FromSeconds(10);
                });

                services.AddLogging(config =>
                {
                    config.AddConsole();
                });

                services.Configure<AppSettings>(hostContext.Configuration.GetSection("AppSettings"));
                services.AddHostedService<TestService>();
                services.AddDbContext<SesContext>();
            });

            return builder;
        }
    }
}
