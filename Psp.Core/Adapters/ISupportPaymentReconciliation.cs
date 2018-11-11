using System.Threading.Tasks;
using Psp.Core.Entities;
using Psp.Core.Messages;

namespace Psp.Core.Adapters
{
    public interface ISupportPaymentReconciliation
    {
        Task<UpdateResponse> Reconcile(PaymentReconciliation request, Transaction transaction);
    }
}
