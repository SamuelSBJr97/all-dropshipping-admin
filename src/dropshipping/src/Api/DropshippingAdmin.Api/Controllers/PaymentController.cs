using DropshippingAdmin.Core.Application.Commands;
using DropshippingAdmin.Core.Application.Queries;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Application.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace DropshippingAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly ICommandHandler<CreatePaymentCommand> _createHandler;
        private readonly IQueryHandler<GetPaymentByIdQuery, Payment> _getByIdHandler;
        public PaymentController(ICommandHandler<CreatePaymentCommand> createHandler, IQueryHandler<GetPaymentByIdQuery, Payment> getByIdHandler)
        {
            _createHandler = createHandler;
            _getByIdHandler = getByIdHandler;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePaymentCommand command)
        {
            await _createHandler.Handle(command, default);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> GetById(Guid id)
        {
            var payment = await _getByIdHandler.Handle(new GetPaymentByIdQuery(id), default);
            if (payment == null) return NotFound();
            return Ok(payment);
        }
    }
}
