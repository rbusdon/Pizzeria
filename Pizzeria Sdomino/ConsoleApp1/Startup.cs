using DatabaseHandler;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Startup
    {
        public static IHostBuilder CreateHostBuilder ()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                    {
                        service.AddDbContext<PizzeriaDBContext>(
                            options => options.UseSqlServer("name=ConnectionStrings:"));
                    }
                );
        }
    }
}
