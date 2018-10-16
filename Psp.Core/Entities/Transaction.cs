using System;

namespace Psp.Core.Entities
{
    public class Transaction
    {
        public string PublicPaymentId { get; set; }
        public string ProviderAccount { get; set; }
        public MethodAction MethodAction { get; set; }
        public Money Money { get; set; }
        public TransactionStatus Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Changed { get; set; }
    }
}
