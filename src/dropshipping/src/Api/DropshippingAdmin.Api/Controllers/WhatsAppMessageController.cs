using DropshippingAdmin.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DropshippingAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WhatsAppMessageController : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping() => Ok("WhatsAppMessage endpoint is up");
        // Adicione endpoints reais conforme implementar CQRS para WhatsAppMessage
    }
}
