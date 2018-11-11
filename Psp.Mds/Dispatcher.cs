using System;
using System.Threading.Tasks;
using Psp.Mds.Queues;
using Psp.Silo.Client;

namespace Psp.Mds
{
    public static class Dispatcher
    {
        public static async Task Start()
        {
            using (var client = await OrleansClient.StartWithRetries())
            {
                while (true)
                {
                    var message = RequestQueue.Dequeue();
                    if (message == null)
                    {
                        await Task.Delay(1_000);
                        continue;
                    }
                    Console.WriteLine($"-- {message}");
                    Task.Run(async () => await client.Process(message));
                }
            }
        }
    }
}
