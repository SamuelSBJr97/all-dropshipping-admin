using DropshippingAdmin.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DropshippingAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping() => Ok("Transaction endpoint is up");
        // Adicione endpoints reais conforme implementar CQRS para Transaction
    }
}
