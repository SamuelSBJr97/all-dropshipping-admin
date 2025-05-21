using DropshippingAdmin.Core.Application.Commands;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace DropshippingAdmin.Core.Application.Handlers
{
    public class CreateTransactionCommandHandler : ICommandHandler<CreateTransactionCommand>
    {
        private readonly IRepository<Transaction> _transactionRepository;
        public CreateTransactionCommandHandler(IRepository<Transaction> transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        public async Task Handle(CreateTransactionCommand command, CancellationToken cancellationToken)
        {
            var transaction = new Transaction
            {
                Id = Guid.NewGuid(),
                TransactionId = command.TransactionId,
                PaymentId = command.PaymentId,
                Gateway = command.Gateway,
                CreatedAt = DateTime.UtcNow
            };
            await _transactionRepository.AddAsync(transaction);
        }
    }
}
