using Orleans;
using Psp.Core;
using System.Threading.Tasks;

namespace Psp.GrainInterfaces
{
    public interface IWithdrawalGrain : IGrain
    {
        Task<UpdateResponse> MakeWithdrawal(PaymentRequest request);
    }
}