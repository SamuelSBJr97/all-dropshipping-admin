using DropshippingAdmin.Core.Contracts;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Services
{
    public class WhatsAppMessagesStatusService : IWhatsAppMessagesStatusService
    {
        public async Task UpdateStatusAsync(Guid messageId, string status)
        {
            // Exemplo: simula atualização de status de mensagem WhatsApp
            await Task.Delay(100);
            System.Console.WriteLine($"Status da mensagem WhatsApp {messageId} atualizado para {status}");
        }
    }
}
