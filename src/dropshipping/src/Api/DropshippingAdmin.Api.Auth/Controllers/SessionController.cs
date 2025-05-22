using Microsoft.AspNetCore.Mvc;
using DropshippingAdmin.Api.Auth.Services;

namespace DropshippingAdmin.Api.Auth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessionController : ControllerBase
    {
        private readonly RedisAuthSessionService _sessionService;
        public SessionController(RedisAuthSessionService sessionService)
        {
            _sessionService = sessionService;
        }

        [HttpGet("validate")] // GET api/session/validate?token=xxx
        public async Task<IActionResult> Validate([FromQuery] string token)
        {
            var session = await _sessionService.GetSessionAsync(token);
            if (session == null)
                return NotFound();
            return Ok(session);
        }
    }
}
