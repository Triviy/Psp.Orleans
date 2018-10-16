using Microsoft.AspNetCore.Mvc;
using Psp.Core.Messages;

namespace Psp.Mds
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueueController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> Enqueue(PaymentRequest request)
        {
            return "OK";
        }

        [HttpPost]
        public ActionResult<string> Enqueue(ProviderReconciliation request)
        {
            return "OK";
        }

        [HttpPost]
        public ActionResult<string> Enqueue(PaymentReconciliation request)
        {
            return "OK";
        }
    }
}
