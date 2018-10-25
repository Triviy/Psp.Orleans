using Microsoft.AspNetCore.Mvc;
using Psp.Core.Messages;
using Psp.Mds.Queues;

namespace Psp.Mds.Handlers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QueueController : ControllerBase
    {
        private readonly IRequestQueue _queue;

        public QueueController(IRequestQueue queue)
        {
            _queue = queue;
        }

        [HttpPost]
        public IActionResult AddPaymentRequest(PaymentRequest request)
        {
            _queue.Enqueue(request);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddProviderReconciliation(ProviderReconciliation request)
        {
            _queue.Enqueue(request);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddPaymentReconciliation(PaymentReconciliation request)
        {
            _queue.Enqueue(request);
            return Ok();
        }
    }
}
