using System;
using System.Threading.Tasks;
using Psp.Core.Adapters;
using Psp.Core.Entities;
using Psp.Core.Messages;

namespace Psp.BusinessLogic.Handlers
{
    class PaymentRequestHandler : IPaymentRequestHandler
    {
        private readonly IAdapterFactory _adapterFactory;

        public PaymentRequestHandler(IAdapterFactory adapterFactory)
        {
            _adapterFactory = adapterFactory;
        }

        public Task Handle(PaymentRequest request)
        {
            switch (request.MethodAction)
            {
                case MethodAction.Deposit:
                    _adapterFactory.Create<ISupportDeposit>(request.ProviderAccount).MakeDeposit(request);
                case MethodAction.Withdrawal:
                    _adapterFactory.Create<ISupportWithdrawal>(request.ProviderAccount).MakeWithdrawal(request);
            }
            
            Console.WriteLine($"{GetType().Name}: {request.PublicPaymentId}");
            return Task.CompletedTask;
        }
    }
}