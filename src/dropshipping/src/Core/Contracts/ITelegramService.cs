namespace DropshippingAdmin.Core.Contracts
{
    public interface ITelegramService
    {
        Task SendMessageAsync(long chatId, string message);
    }
}
