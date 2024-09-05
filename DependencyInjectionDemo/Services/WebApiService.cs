using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Services
{
    public class WebApiService : IDataService
    {
        public string GetData()
        {
            return "來自 Web API 的資料";
        }
    }
}
