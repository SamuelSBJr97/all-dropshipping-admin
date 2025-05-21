using DropshippingAdmin.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DropshippingAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WhatsAppMessagesStatusController : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping() => Ok("WhatsAppMessagesStatus endpoint is up");
        // Adicione endpoints reais conforme implementar CQRS para WhatsAppMessagesStatus
    }
}
