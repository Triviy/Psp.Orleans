using System.Threading.Tasks;
using Orleans;
using Psp.BusinessLogic.Handlers;
using Psp.Core.Entities;
using Psp.Core.Messages;
using Psp.GrainInterfaces;

namespace Psp.Grains
{
    public class TransactionGrain : Grain<Transaction>, ITransactionGrain
    {
        private readonly IPaymentRequestHandler _paymentRequestHandler;
        private readonly IPaymentReconciliationHandler _paymentReconciliationHandler;
        private readonly IProviderNotificationHandler _providerNotificationHandler;

        public TransactionGrain(
            IPaymentRequestHandler paymentRequestHandler,
            IPaymentReconciliationHandler paymentReconciliationHandler,
            IProviderNotificationHandler providerNotificationHandler)
        {
            _paymentRequestHandler = paymentRequestHandler;
            _paymentReconciliationHandler = paymentReconciliationHandler;
            _providerNotificationHandler = providerNotificationHandler;
        }

        public Task Create(PaymentRequest request)
        {
            return _paymentRequestHandler.Handle(request);
        }

        public Task Check(PaymentReconciliation request)
        {
            return _paymentReconciliationHandler.Handle(request, State);
        }

        public Task Update(ProviderNotification request)
        {
            return _providerNotificationHandler.Handle(request, State);
        }
    }
}
