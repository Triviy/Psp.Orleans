using System.Threading.Tasks;
using Psp.Core.Entities;
using Psp.Core.Messages;

namespace Psp.BusinessLogic.Handlers
{
    public interface IPaymentReconciliationHandler
    {
        Task Handle(PaymentReconciliation request, Transaction transaction);
    }
}
