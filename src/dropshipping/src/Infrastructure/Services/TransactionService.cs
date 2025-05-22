using DropshippingAdmin.Core.Contracts;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Services
{
    public class TransactionService : ITransactionService
    {
        public async Task<Guid> CreateTransactionAsync(Guid paymentId, string gateway)
        {
            // Exemplo: simula criação de transação
            await Task.Delay(100);
            return Guid.NewGuid();
        }
        public async Task<bool> ConfirmTransactionAsync(Guid transactionId)
        {
            // Exemplo: simula confirmação de transação
            await Task.Delay(100);
            return true;
        }
    }
}
