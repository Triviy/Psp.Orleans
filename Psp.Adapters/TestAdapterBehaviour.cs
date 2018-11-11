using System;
using System.Threading.Tasks;
using Psp.Core.Entities;
using Psp.Core.Messages;

namespace Psp.Adapters
{
    internal static class TestAdapterBehaviour
    {
        private static readonly Random Random = new Random();

        public static async Task<UpdateResponse> SimulateRequestToProvider(string publicPaymentId)
        {
            await Task.Delay(Random.Next(1_000, 30_000));
            return new UpdateResponse
            {
                PublicPaymentId = publicPaymentId,
                Status = GetRandomStatus()
            };
        }

        private static TransactionStatus GetRandomStatus()
        {
            var values = Enum.GetValues(typeof(TransactionStatus));
            return (TransactionStatus)values.GetValue(Random.Next(values.Length));
        }
    }
}
