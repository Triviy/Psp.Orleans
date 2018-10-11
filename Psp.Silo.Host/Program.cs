using Orleans.Hosting;
using System;
using System.Net;
using System.Threading.Tasks;
using Orleans.Configuration;
using Psp.Grains;
using Orleans;

namespace Psp.Silo.Host
{
    class Program
    {
        public static async Task<int> Main(string[] args)
        {
            try
            {
                var host = await StartSilo();
                Console.WriteLine("Press Enter to terminate...");
                Console.ReadLine();

                await host.StopAsync();

                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 1;
            }
        }

        private static async Task<ISiloHost> StartSilo()
        {
            // define the cluster configuration
            var siloPort = 11111;
            int gatewayPort = 30000;
            var siloAddress = IPAddress.Loopback;
            var builder = new SiloHostBuilder()
                .Configure<ClusterOptions>(options => options.ClusterId = "helloworldcluster")
                .UseDevelopmentClustering(options => options.PrimarySiloEndpoint = new IPEndPoint(siloAddress, siloPort))
                .ConfigureEndpoints(siloAddress, siloPort, gatewayPort)
                .ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(AdapterBaseGrain).Assembly).WithReferences())
                .ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(TransactionGrain).Assembly).WithReferences());
                //.ConfigureLogging(logging => logging.AddConsole());

            var host = builder.Build();
            await host.StartAsync();
            return host;
        }
    }
}
