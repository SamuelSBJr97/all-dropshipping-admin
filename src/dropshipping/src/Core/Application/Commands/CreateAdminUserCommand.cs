namespace DropshippingAdmin.Core.Application.Commands
{
    public class CreateAdminUserCommand : ICommand
    {
        public string Name { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public string Secret { get; set; } = string.Empty;
        public string? Email { get; set; }
    }
}
