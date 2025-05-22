namespace DropshippingAdmin.Core.Contracts
{
    public interface IPushNotificationService
    {
        Task SendPushAsync(string deviceToken, string title, string body);
    }
}
