using Microsoft.Extensions.DependencyInjection;
using Psp.BusinessLogic.Handlers;

namespace Psp.BusinessLogic.Configuration
{
    public static class DependencyExtension
    {
        public static void RegisterBusinessLogicDependencies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IPaymentRequestHandler, PaymentRequestHandler>();
            serviceCollection.AddSingleton<IPaymentReconciliationHandler, PaymentReconciliationHandler>();
            serviceCollection.AddSingleton<IProviderNotificationHandler, ProviderNotificationHandler>();
            serviceCollection.AddSingleton<IProviderReconciliationHandler, ProviderReconciliationHandler>();

            serviceCollection.AddSingleton<IAdapterFactory, AdapterFactory>();
        }
    }
}
