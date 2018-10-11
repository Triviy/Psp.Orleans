using Psp.Core;

namespace Psp.BusinessLogic
{
    public interface IPaymentRequestHandler
    {
        void Handle(PaymentRequest request);
    }
}