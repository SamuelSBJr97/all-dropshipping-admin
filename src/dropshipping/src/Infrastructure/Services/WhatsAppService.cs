using DropshippingAdmin.Core.Contracts;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Services
{
    public class WhatsAppService : IWhatsAppService
    {
        public async Task SendMessageAsync(Guid userId, string message)
        {
            // Aqui você integraria com uma API real de WhatsApp (ex: Twilio, Zenvia, etc)
            // Exemplo fictício:
            await Task.Delay(100); // Simula chamada HTTP
            System.Console.WriteLine($"[WhatsApp] Mensagem enviada para usuário {userId}: {message}");
        }
    }
}
