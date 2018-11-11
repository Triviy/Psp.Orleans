using System;
using System.Threading.Tasks;
using Psp.Core.Messages;

namespace Psp.BusinessLogic.Handlers
{
    class ProviderReconciliationHandler : IProviderReconciliationHandler
    {
        public Task Handle(ProviderReconciliation request)
        {
            Console.WriteLine($"{GetType().Name}: {request.ProviderAccount}");
            return Task.CompletedTask;
        }
    }
}