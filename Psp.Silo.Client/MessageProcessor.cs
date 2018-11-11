using System;
using System.Threading.Tasks;
using Orleans;
using Psp.Core.Messages;
using Psp.GrainInterfaces;

namespace Psp.Silo.Client
{
    public class MessageProcessor: IDisposable
    {
        private readonly IClusterClient _clusterClient;

        public MessageProcessor(IClusterClient clusterClient)
        {
            _clusterClient = clusterClient;
        }

        public void Dispose()
        {
            _clusterClient?.Dispose();
        }

        public async Task Process(PspMessage message)
        {
            switch (message)
            {
                case PaymentRequest paymentRequest:
                    await _clusterClient.GetGrain<ITransactionGrain>(paymentRequest.PublicPaymentId).Create(paymentRequest);
                    break;
                case PaymentReconciliation paymentReconciliation:
                    await _clusterClient.GetGrain<ITransactionGrain>(paymentReconciliation.PublicPaymentId).Check(paymentReconciliation);
                    break;
                case ProviderNotification providerNotification:
                    await _clusterClient.GetGrain<ITransactionGrain>(providerNotification.PublicPaymentId).Update(providerNotification);
                    break;
                case ProviderReconciliation providerReconciliation:
                    await Task.Delay(1_000);
                    break;
                default:
                    throw new ArgumentException(nameof(message));
            }
        }
    }
}
