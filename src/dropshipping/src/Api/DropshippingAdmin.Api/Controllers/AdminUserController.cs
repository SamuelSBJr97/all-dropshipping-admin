using DropshippingAdmin.Core.Application.Commands;
using DropshippingAdmin.Core.Application.Queries;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Application.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace DropshippingAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminUserController : ControllerBase
    {
        private readonly ICommandHandler<CreateAdminUserCommand> _createHandler;
        private readonly IQueryHandler<GetAdminUserByIdQuery, AdminUser> _getByIdHandler;
        public AdminUserController(ICommandHandler<CreateAdminUserCommand> createHandler, IQueryHandler<GetAdminUserByIdQuery, AdminUser> getByIdHandler)
        {
            _createHandler = createHandler;
            _getByIdHandler = getByIdHandler;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateAdminUserCommand command)
        {
            await _createHandler.Handle(command, default);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AdminUser>> GetById(Guid id)
        {
            var admin = await _getByIdHandler.Handle(new GetAdminUserByIdQuery(id), default);
            if (admin == null) return NotFound();
            return Ok(admin);
        }
    }
}
