using System.Threading.Tasks;
using Psp.Core.Messages;

namespace Psp.BusinessLogic.Handlers
{
    public interface IProviderNotificationHandler
    {
        Task Handle(ProviderNotification request);
    }
}
