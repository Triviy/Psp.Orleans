using System;
using System.Threading.Tasks;
using Psp.Core.Adapters;
using Psp.Core.Entities;
using Psp.Core.Messages;

namespace Psp.Adapters.Adyen
{
    public class AdyenAdapter: AdapterBase,
        ISupportDeposit,
        ISupportWithdrawal,
        ISupportPaymentReconciliation,
        ISupportProviderReconciliation,
        ISupportNotification
    {
        public Task<UpdateResponse> MakeDeposit(PaymentRequest request)
        {
            return TestAdapterBehaviour.SimulateRequestToProvider(request.PublicPaymentId);
        }

        public Task<UpdateResponse> MakeWithdrawal(PaymentRequest request)
        {
            return TestAdapterBehaviour.SimulateRequestToProvider(request.PublicPaymentId);
        }

        public Task<UpdateResponse> Reconcile(PaymentReconciliation request, Transaction transaction)
        {
            return TestAdapterBehaviour.SimulateRequestToProvider(request.PublicPaymentId);
        }

        public Task<PaymentReconciliation[]> Reconcile(ProviderReconciliation request)
        {
            throw new NotImplementedException();
        }

        public Task<ProviderNotification> Parse(string request)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateResponse> ProcessNotification(ProviderNotification request, Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
