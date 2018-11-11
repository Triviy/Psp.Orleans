using System.Threading.Tasks;
using Orleans;
using Psp.Core.Messages;

namespace Psp.GrainInterfaces
{
    public interface ITransactionGrain: IGrainWithStringKey
    {
        Task Create(PaymentRequest request);
        Task Check(PaymentReconciliation request);
        Task Update(ProviderNotification request);
    }
}