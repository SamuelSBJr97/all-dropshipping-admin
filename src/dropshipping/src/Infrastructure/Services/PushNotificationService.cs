using DropshippingAdmin.Core.Contracts;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Services
{
    public class PushNotificationService : IPushNotificationService
    {
        public async Task SendPushAsync(string deviceToken, string title, string body)
        {
            // Aqui você integraria com um serviço real de push (ex: Firebase, OneSignal, Expo, etc)
            await Task.Delay(100); // Simula chamada HTTP
            System.Console.WriteLine($"[Push] Notificação enviada para {deviceToken}: {title} - {body}");
        }
    }
}
