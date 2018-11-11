using System.Threading.Tasks;
using Psp.Core.Messages;

namespace Psp.Core.Adapters
{
    public interface ISupportProviderReconciliation: ISupportPaymentReconciliation
    {
        Task<PaymentReconciliation[]> Reconcile(ProviderReconciliation request);
    }
}
