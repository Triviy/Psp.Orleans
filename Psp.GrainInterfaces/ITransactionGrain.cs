using System.Threading.Tasks;
using Orleans;
using Psp.Core;
using Psp.Core.Entities;
using Psp.Core.Messages;

namespace Psp.GrainInterfaces
{
    public interface ITransactionGrain: IGrain
    {
        Task Create(PaymentRequest request);
        Task Update(UpdateResponse response);
        Task<Transaction> Get(string publicPaymentId);
    }
}
