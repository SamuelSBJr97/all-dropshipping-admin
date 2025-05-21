namespace DropshippingAdmin.Core.Contracts
{
    public interface IWhatsAppService
    {
        Task SendMessageAsync(Guid userId, string message);
    }
}
