using ConsoleUI.Configuration;
using EFCore.BulkExtensions;
using EfCoreBulks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        private static async Task Main(string[] args)
        {
            var builder = new HostBuilder()
                .ConfigureApp(args)
                .ConfigureHost(args)
                .ConfigureServices()
                .ConfigureLogging();

            await builder.RunConsoleAsync();
        }
    }
}
