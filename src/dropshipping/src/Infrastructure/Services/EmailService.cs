using DropshippingAdmin.Core.Contracts;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string to, string subject, string body)
        {
            // Exemplo: simula envio de e-mail
            await Task.Delay(100);
            System.Console.WriteLine($"E-mail enviado para {to}: {subject}");
        }
    }
}
