using ConsoleUI.Configuration;
using Microsoft.Extensions.Hosting;
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
