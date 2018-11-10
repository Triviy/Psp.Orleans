using Microsoft.AspNetCore.Mvc;
using Psp.Core.Messages;
using Psp.OuterWorld.Queues;

namespace Psp.OuterWorld.Controllers
{
    [ApiController]
    [Route("api/{controller}/{action}")]
    public class PaasController : ControllerBase
    {
        public IActionResult UpdatePayment(UpdateResponse updateResponse)
        {
            ResponseQueue.Enqueue(updateResponse);
            return Ok();
        }
    }
}
