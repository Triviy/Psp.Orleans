using Psp.Core.Entities;

namespace Psp.Core.Messages
{
    public class PaymentRequest: PspMessage
    {
        public string PublicPaymentId { get; set; }
        public string ProviderAccount { get; set; }
        public MethodAction MethodAction { get; set; }
        public Money Money { get; set; }
    }
}