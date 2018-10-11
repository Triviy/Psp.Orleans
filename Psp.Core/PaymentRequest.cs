namespace Psp.Core
{
    public class PaymentRequest
    {
        public string PublicPaymentId { get; set; }
        public string ProviderAccount { get; set; }
        public MethodAction MethodAction { get; set; }
        public Money Money { get; set; }
    }
}
