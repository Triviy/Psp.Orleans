using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Psp.Mds.Queues;

namespace Psp.Mds
{
    public static class Dispatcher
    {
        public static async Task Start()
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

            }
        }
    }
}
