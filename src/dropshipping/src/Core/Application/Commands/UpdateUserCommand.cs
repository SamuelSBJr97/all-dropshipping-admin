namespace DropshippingAdmin.Core.Application.Commands
{
    public class UpdateUserCommand : ICommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
