namespace DropshippingAdmin.Core.Application.Commands
{
    public class DeleteUserCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}
