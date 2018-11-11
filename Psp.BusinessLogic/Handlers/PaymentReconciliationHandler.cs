using System;
using System.Threading.Tasks;
using Psp.Core.Entities;
using Psp.Core.Messages;

namespace Psp.BusinessLogic.Handlers
{
    class PaymentReconciliationHandler : IPaymentReconciliationHandler
    {
        public Task Handle(PaymentReconciliation request, Transaction transaction)
        {
            Console.WriteLine($"{GetType().Name}: {request.PublicPaymentId}");
            return Task.CompletedTask;
        }
    }
}