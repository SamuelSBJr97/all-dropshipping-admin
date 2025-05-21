namespace DropshippingAdmin.Core.Application.Commands
{
    public class CreateNotificationCommand : ICommand
    {
        public Guid UserId { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
