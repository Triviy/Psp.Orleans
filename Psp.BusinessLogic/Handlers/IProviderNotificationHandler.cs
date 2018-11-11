using System.Threading.Tasks;
using Psp.Core.Entities;
using Psp.Core.Messages;

namespace Psp.BusinessLogic.Handlers
{
    public interface IProviderNotificationHandler
    {
        Task Handle(ProviderNotification request, Transaction transaction);
    }
}
