using DropshippingAdmin.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DropshippingAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsStatusController : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping() => Ok("PaymentsStatus endpoint is up");
        // Adicione endpoints reais conforme implementar CQRS para PaymentsStatus
    }
}
