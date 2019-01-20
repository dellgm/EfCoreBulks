using EfCoreBulks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class TestService : IHostedService, IDisposable
    {
        private readonly SesContext _context;
        private readonly AppSettings _settings;
        private readonly IApplicationLifetime _lifetime;

        public TestService(
            SesContext context, 
            IOptions<AppSettings> settings, 
            IApplicationLifetime lifetime)
        {
            _context = context;
            _settings = settings.Value;
            _lifetime = lifetime;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            var result = await _context.SesPriceHistory.AsNoTracking().ToListAsync();
            int count = 0;

            foreach (var item in result)
            {
                
                Console.Write($"\r#{count++} {item.Price}, {item.OldPrice}, {item.PercentDiscount}, {item.RivileCode}, {item.DateCreated}");
            }

        }

        public  Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Job done existing in 3s");

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
