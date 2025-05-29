using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Application.Commands;
using DropshippingAdmin.Core.Application.Handlers.Commands;
using DropshippingAdmin.Core.Application.Handlers.Queries;
using DropshippingAdmin.Core.Application.Queries;

namespace DropshippingAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PaymentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Payment>> GetAll()
        {
            return await _mediator.Send(new ListPaymentsQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> GetById(Guid id)
        {
            var payment = await _mediator.Send(new GetPaymentByIdQuery(id));
            if (payment == null) return NotFound();
            return payment;
        }

        [HttpPost]
        public async Task<ActionResult<Payment>> Create([FromBody] CreatePaymentCommand command)
        {
            var payment = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = payment.Id }, payment);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Payment>> Update(Guid id, [FromBody] UpdatePaymentCommand command)
        {
            if (id != command.Id) return BadRequest();
            var payment = await _mediator.Send(command);
            if (payment == null) return NotFound();
            return payment;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _mediator.Send(new DeletePaymentCommand(id));
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
