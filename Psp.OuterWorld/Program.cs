using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Psp.OuterWorld.MdsApi;
using RestEase;

namespace Psp.OuterWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Task.Run(() => RunHost(args));

            Task.Run(() => Paas.StartPaymentRequests().GetAwaiter().GetResult());
            Task.Run(() => Paas.StartProviderReconciliation().GetAwaiter().GetResult());

            Console.ReadLine();
        }

        private static void RunHost(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) => { })
                .UseUrls("http://localhost:5035/")
                .UseStartup<Startup>()
                .Build()
                .Run();
        }
    }
}
