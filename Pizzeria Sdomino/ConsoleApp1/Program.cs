using DatabaseHandler;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbContext = Startup.CreateHostBuilder().Build().Services.GetService<PizzeriaDBContext>();
        }
    }
}