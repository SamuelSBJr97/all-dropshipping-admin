namespace DropshippingAdmin.Core.Contracts
{
    public interface IWhatsAppMessagesStatusService
    {
        Task UpdateStatusAsync(Guid messageId, string status);
    }
}
