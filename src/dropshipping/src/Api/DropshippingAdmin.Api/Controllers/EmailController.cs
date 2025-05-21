using Microsoft.AspNetCore.Mvc;

namespace DropshippingAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        [HttpPost("send")]
        public IActionResult Send([FromBody] object emailDto) => Ok("Email enviado (mock)");
    }
}
