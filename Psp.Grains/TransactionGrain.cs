using System.Threading.Tasks;
using Psp.Core;
using Psp.GrainInterfaces;

namespace Psp.Grains
{
    public class TransactionGrain : ITransactionGrain
    {
        public Task Create(PaymentRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(UpdateResponse response)
        {
            throw new System.NotImplementedException();
        }

        public Task<Transaction> Get(string publicPaymentId)
        {
            throw new System.NotImplementedException();
        }
    }
}
