using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace my_angular_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Web application starting.");
            CreateWebHostBuilder(args).Build().Run();
            Console.WriteLine("Web application started.");
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) => WebHost.CreateDefaultBuilder(args)
                                                                                    .UseStartup<Startup>();
    }
}
