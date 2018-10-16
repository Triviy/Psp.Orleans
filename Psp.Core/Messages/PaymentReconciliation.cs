namespace Psp.Core.Messages
{
    public class PaymentReconciliation : PspMessage
    {
        public string PublicPaymentId { get; set; }
        public string ProviderAccount { get; set; }
    }
}