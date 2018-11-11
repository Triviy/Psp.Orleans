using System.Threading.Tasks;
using Psp.Core.Messages;

namespace Psp.BusinessLogic.Handlers
{
    public interface IProviderReconciliationHandler
    {
        Task Handle(ProviderReconciliation request);
    }
}
