using Psp.Core.Entities;

namespace Psp.Core.Messages
{
    public class UpdateResponse
    {
        public string PublicPaymentId { get; set; }
        public TransactionStatus Status { get; set; }
    }
}
