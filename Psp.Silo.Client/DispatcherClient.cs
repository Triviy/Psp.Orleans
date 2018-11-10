using System;
using System.Threading.Tasks;
using Orleans;
using Psp.Core.Messages;
using Psp.GrainInterfaces;

namespace Psp.Silo.Client
{
    public class DispatcherClient: IDisposable
    {
        private readonly IClusterClient _clusterClient;

        public DispatcherClient(IClusterClient clusterClient)
        {
            _clusterClient = clusterClient;
        }

        public void Dispose()
        {
            _clusterClient?.Dispose();
        }

        public async Task Dispatch(PspMessage message)
        {
            var dispatcher = _clusterClient.GetGrain<IDispatcherGrain>(0);
            await dispatcher.Dispatch(message);
        }
    }
}
