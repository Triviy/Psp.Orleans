using System.Threading.Tasks;
using Psp.Core.Messages;
using RestEase;

namespace Psp.OuterWorld.MdsApi
{
    public interface IMdsApi
    {
        [Post("AddPaymentRequest")]
        Task AddPaymentRequest([Body]PaymentRequest paymentRequest);

        [Post("AddProviderReconciliation")]
        Task AddProviderReconciliation([Body]ProviderReconciliation paymentRequest);

        [Post("AddPaymentReconciliation")]
        Task AddPaymentReconciliation([Body]PaymentReconciliation paymentRequest);
    }
}
