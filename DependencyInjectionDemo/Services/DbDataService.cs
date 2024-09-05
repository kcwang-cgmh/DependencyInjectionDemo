namespace DependencyInjectionDemo.Services
{
    public class DbDataService : IDataService
    {
        public string GetData()
        {
            return "來自資料庫的資料";
        }
    }
}
