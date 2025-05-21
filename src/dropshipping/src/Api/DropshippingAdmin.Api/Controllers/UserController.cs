using DropshippingAdmin.Core.Application.Commands;
using DropshippingAdmin.Core.Application.Queries;
using DropshippingAdmin.Core.Application.Dtos;
using DropshippingAdmin.Core.Application.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace DropshippingAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ICommandHandler<CreateUserCommand> _createUserHandler;
        private readonly IQueryHandler<GetUserByIdQuery, UserDto> _getUserByIdHandler;
        public UserController(ICommandHandler<CreateUserCommand> createUserHandler, IQueryHandler<GetUserByIdQuery, UserDto> getUserByIdHandler)
        {
            _createUserHandler = createUserHandler;
            _getUserByIdHandler = getUserByIdHandler;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserCommand command)
        {
            await _createUserHandler.Handle(command, default);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetById(Guid id)
        {
            var user = await _getUserByIdHandler.Handle(new GetUserByIdQuery(id), default);
            if (user == null) return NotFound();
            return Ok(user);
        }
    }
}
