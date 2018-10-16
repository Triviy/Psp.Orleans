namespace Psp.Core.Messages
{
    public class ProviderNotification: PspMessage
    {
        public string PublicPaymentId { get; set; }
        public string ProviderPaymentId { get; set; }
        public string ProviderAccount { get; set; }
    }
}
