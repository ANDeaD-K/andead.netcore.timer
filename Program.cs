using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using andead.netcore.timer.Services;

namespace andead.netcore.timer
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var host = new HostBuilder()
                 .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<TimedHostedService>();
                })
                .Build();

            await host.RunAsync();
        }
    }
}
