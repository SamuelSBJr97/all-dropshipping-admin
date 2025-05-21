using Microsoft.AspNetCore.Mvc;

namespace DropshippingAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminAuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] object loginDto) => Ok("Login mock");
        [HttpPost("2fa")]
        public IActionResult TwoFactor([FromBody] object twoFactorDto) => Ok("2FA mock");
    }
}
