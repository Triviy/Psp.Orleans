using System.Threading.Tasks;
using Orleans;
using Psp.Core;

namespace Psp.GrainInterfaces
{
    public interface ITransactionGrain: IGrain
    {
        Task Create(PaymentRequest request);
        Task Update(UpdateResponse response);
        Task<Transaction> Get(string publicPaymentId);
    }
}
