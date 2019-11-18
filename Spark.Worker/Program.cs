using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin.Hosting;

namespace Spark.Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            var isAppRunning = true;
            var owinOptions = new StartOptions { Urls = { "http://localhost:9000/" } };
            var urls = string.Join(", ", owinOptions.Urls);
            do
            {
                using (WebApp.Start<Startup>(owinOptions))
                {
                    Console.WriteLine($"Server Is Running At {urls}");
                    var command = Console.ReadKey();
                    switch (command.Key)
                    {
                        case ConsoleKey.R:
                            continue;
                        case ConsoleKey.E:
                            isAppRunning = false;
                            break;
                    }
                }
            } while (isAppRunning);
        }
    }
}
