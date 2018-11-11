using System.Threading.Tasks;
using Psp.Core.Entities;
using Psp.Core.Messages;

namespace Psp.Core.Adapters
{
    public interface ISupportNotification
    {
        Task<ProviderNotification> Parse(string request);
        Task<UpdateResponse> ProcessNotification(ProviderNotification request, Transaction transaction);
    }
}
