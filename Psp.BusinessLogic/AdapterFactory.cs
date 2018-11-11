using System;
using Psp.Adapters.Adyen;
using Psp.Adapters.Citadel;
using Psp.Adapters.GluePay;
using Psp.Core;
using Psp.Core.Adapters;

namespace Psp.BusinessLogic
{
    class AdapterFactory : IAdapterFactory
    {
        public T Create<T>(string providerAccount) where T: class 
        {
            return CreateAdapter(providerAccount) as T ?? throw new ArgumentException(typeof(T).Name);
        }

        private AdapterBase CreateAdapter(string providerAccount)
        {
            switch (providerAccount)
            {
                case Constants.ProviderAccounts.Adyen:
                    return new AdyenAdapter();
                case Constants.ProviderAccounts.Citadel:
                    return new CitadelAdapter();
                case Constants.ProviderAccounts.GLuePay:
                    return new GluePayAdapter();
                default:
                    throw new ArgumentException(nameof(providerAccount));
            }
        }
    }
}