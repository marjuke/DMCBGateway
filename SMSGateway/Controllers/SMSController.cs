using Application.SMS;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace SMSGateway.Controllers
{
    public class SMSController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateSMS(Messageinfo messageinfo)
        {
            return Ok(await Mediator.Send(new Create.Command { Messageinfo = messageinfo }));
        }
    }
}
