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
        public Task Dispatch(PspMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
