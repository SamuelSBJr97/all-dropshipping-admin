using DropshippingAdmin.Core.Application.Commands;
using DropshippingAdmin.Core.Application.Queries;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Application.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace DropshippingAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly ICommandHandler<CreateNotificationCommand> _createHandler;
        private readonly IQueryHandler<GetNotificationByIdQuery, Notification> _getByIdHandler;
        public NotificationController(ICommandHandler<CreateNotificationCommand> createHandler, IQueryHandler<GetNotificationByIdQuery, Notification> getByIdHandler)
        {
            _createHandler = createHandler;
            _getByIdHandler = getByIdHandler;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateNotificationCommand command)
        {
            await _createHandler.Handle(command, default);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Notification>> GetById(Guid id)
        {
            var notification = await _getByIdHandler.Handle(new GetNotificationByIdQuery(id), default);
            if (notification == null) return NotFound();
            return Ok(notification);
        }
    }
}
