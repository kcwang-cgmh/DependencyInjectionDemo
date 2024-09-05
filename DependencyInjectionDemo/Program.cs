using DependencyInjectionDemo.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DependencyInjectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IDataService, DbDataService>();
                })
                .Build();

            var dataService = host.Services.GetRequiredService<IDataService>();
            Console.WriteLine(dataService.GetData());
        }
    }
}
