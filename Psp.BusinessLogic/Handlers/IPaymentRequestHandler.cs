using System.Threading.Tasks;
using Psp.Core.Messages;

namespace Psp.BusinessLogic.Handlers
{
    public interface IPaymentRequestHandler
    {
        Task Handle(PaymentRequest request);
    }
}
