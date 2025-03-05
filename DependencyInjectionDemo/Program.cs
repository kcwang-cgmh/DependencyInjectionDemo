using DependencyInjectionDemo.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DependencyInjectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 建立 DI 容器
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IDataService, DbDataService>()
                .BuildServiceProvider();

            // 從 DI 容器取得服務
            var dataService = serviceProvider.GetService<IDataService>();

            // 使用服務
            var data = dataService?.GetData();

            // 輸出結果
            if (!string.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine(data);
            }
        }
    }
}
