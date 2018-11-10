using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Psp.Mds
{
    class Program
    {
        public static void Main(string[] args)
        {
            Task.Run(() => RunHost(args));
            Task.Run(() => Dispatcher.Start().GetAwaiter().GetResult());
            Console.ReadLine();
        }

        private static void RunHost(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) => { })
                .UseUrls("http://localhost:5034/")
                .UseStartup<Startup>()
                .Build()
                .Run();
            Console.WriteLine("test");
        }
    }
}
