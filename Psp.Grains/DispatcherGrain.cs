using System;
using System.Threading.Tasks;
using Orleans;
using Orleans.Concurrency;
using Psp.Core.Messages;
using Psp.GrainInterfaces;

namespace Psp.Grains
{
    [StatelessWorker]
    public class DispatcherGrain: Grain, IDispatcherGrain
    {
        public async Task Dispatch(PspMessage message)
        {
            if (message is PaymentRequest paymentRequest)
                Console.WriteLine($"Working on {paymentRequest.PublicPaymentId}");
            await Task.Delay(10_000);
        }
    }
}
