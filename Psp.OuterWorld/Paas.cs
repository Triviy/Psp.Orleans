using System;
using Psp.Core.Entities;
using Psp.Core.Messages;

namespace Psp.OuterWorld
{
    static class Paas
    {
        private static readonly Random _random = new Random();

        public static PaymentRequest CreatePaymentRequest()
        {
            return new PaymentRequest
            {
                PublicPaymentId = Guid.NewGuid().ToString(),
                MethodAction = (MethodAction) _random.Next(1, 2),
                ProviderAccount = "",
                Money = new Money
                {
                    Amount = _random.Next(1, 1000),
                    Currency = 
                }
            };
        }
    }
}
