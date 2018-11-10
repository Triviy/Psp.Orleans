using Microsoft.AspNetCore.Mvc;
using Psp.Core.Messages;
using Psp.Mds.Queues;
using System;

namespace Psp.Mds.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QueueController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddPaymentRequest(PaymentRequest request)
        {
            RequestQueue.Enqueue(request);
            Console.WriteLine($"+++ PaymentRequest: {request.PublicPaymentId}");
            return Ok();
        }

        [HttpPost]
        public IActionResult AddProviderReconciliation(ProviderReconciliation request)
        {
            RequestQueue.Enqueue(request);
            Console.WriteLine($"+++ ProviderReconciliation: {request.ProviderAccount}");
            return Ok();
        }

        [HttpPost]
        public IActionResult AddPaymentReconciliation(PaymentReconciliation request)
        {
            RequestQueue.Enqueue(request);
            Console.WriteLine($"+++ PaymentReconciliation: {request.ProviderAccount}");
            return Ok();
        }
    }
}
