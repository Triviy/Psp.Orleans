using System;
using System.Net;
using System.Threading.Tasks;
using Orleans;
using Orleans.Configuration;
using Orleans.Runtime;
using Psp.GrainInterfaces;

namespace Psp.Silo.Client
{
    public class OrleansClient
    {
        public static async Task<MessageProcessor> StartWithRetries(int initializeAttemptsBeforeFailing = 5)
        {
            int attempt = 0;
            IClusterClient client;
            while (true)
            {
                try
                {
                    var siloAddress = IPAddress.Loopback;
                    var gatewayPort = 30000;
                    client = new ClientBuilder()
                        .Configure<ClusterOptions>(options =>
                        {
                            options.ServiceId = "PspOrleans";
                            options.ClusterId = "psp-cluster";
                        })
                        .UseStaticClustering(options => options.Gateways.Add((new IPEndPoint(siloAddress, gatewayPort)).ToGatewayUri()))
                        .ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(ITransactionGrain).Assembly).WithReferences())
                        .Build();

                    await client.Connect();
                    Console.WriteLine("OrleansClient successfully connect to silo host");
                    break;
                }
                catch (SiloUnavailableException)
                {
                    attempt++;
                    Console.WriteLine($"Attempt {attempt} of {initializeAttemptsBeforeFailing} failed to initialize the Orleans client.");
                    if (attempt > initializeAttemptsBeforeFailing)
                    {
                        throw;
                    }
                    await Task.Delay(TimeSpan.FromSeconds(4));
                }
            }

            return new MessageProcessor(client);
        }
    }
}
