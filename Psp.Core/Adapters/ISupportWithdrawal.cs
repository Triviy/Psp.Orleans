using System.Threading.Tasks;
using Psp.Core.Messages;

namespace Psp.Core.Adapters
{
    public interface ISupportWithdrawal
    {
        Task<UpdateResponse> MakeWithdrawal(PaymentRequest request);
    }
}
