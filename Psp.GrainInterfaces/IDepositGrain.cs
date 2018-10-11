using Orleans;
using Psp.Core;
using System.Threading.Tasks;

namespace Psp.GrainInterfaces
{
    public interface IDepositGrain : IGrain
    {
        Task<UpdateResponse> MakeDeposit(PaymentRequest request);
    }
}