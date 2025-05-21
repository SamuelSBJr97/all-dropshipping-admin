namespace DropshippingAdmin.Core.Contracts
{
    public interface INotificationService
    {
        Task SendNotificationAsync(Guid userId, string type, string content);
    }
}
