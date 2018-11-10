using System;
using System.Threading.Tasks;
using Psp.Core;
using Psp.Core.Entities;
using Psp.Core.Messages;
using Psp.OuterWorld.MdsApi;
using RestEase;

namespace Psp.OuterWorld
{
    public static class Paas
    {
        private static readonly Random Random = new Random();
        private static readonly IMdsApi Client = RestClient.For<IMdsApi>("http://localhost:5034/api/Queue");

        public static async Task StartPaymentRequests()
        {
            while (true)
            {
                await Task.Delay(Random.Next(1_000, 2_000));
                await Client.AddPaymentRequest(new PaymentRequest
                {
                    PublicPaymentId = Guid.NewGuid().ToString(),
                    MethodAction = (MethodAction)Random.Next(1, 2),
                    ProviderAccount = GetRandomProviderAccount(),
                    Money = new Money
                    {
                        Amount = Random.Next(1, 1000),
                        Currency = "EUR"
                    }
                });
            }
        }

        public static async Task StartProviderReconciliation()
        {
            while (true)
            {
                await Task.Delay(Random.Next(30_000, 60_000));
                await Client.AddProviderReconciliation(new ProviderReconciliation
                {
                    ProviderAccount = GetRandomProviderAccount()
                });
            }
        }


        private static string GetRandomProviderAccount()
        {
            var accounts = Constants.PaymentMethods.GetAll();
            return accounts[Random.Next(accounts.Count - 1)];
        } 
    }
}
