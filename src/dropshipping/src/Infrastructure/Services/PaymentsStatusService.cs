using DropshippingAdmin.Core.Contracts;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Services
{
    public class PaymentsStatusService : IPaymentsStatusService
    {
        public async Task UpdateStatusAsync(Guid paymentId, string status)
        {
            // Exemplo: simula atualização de status de pagamento
            await Task.Delay(100);
            System.Console.WriteLine($"Status do pagamento {paymentId} atualizado para {status}");
        }
    }
}
