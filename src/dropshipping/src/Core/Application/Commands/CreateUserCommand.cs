using DropshippingAdmin.Core.Application.Dtos;

namespace DropshippingAdmin.Core.Application.Commands
{
    public class CreateUserCommand : ICommand
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
