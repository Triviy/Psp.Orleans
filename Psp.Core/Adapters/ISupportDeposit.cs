using System.Threading.Tasks;
using Psp.Core.Messages;

namespace Psp.Core.Adapters
{
    public interface ISupportDeposit
    {
        Task<UpdateResponse> MakeDeposit(PaymentRequest request);
    }
}
