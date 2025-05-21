using DropshippingAdmin.Core.Application.Commands;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace DropshippingAdmin.Core.Application.Handlers
{
    public class CreatePaymentCommandHandler : ICommandHandler<CreatePaymentCommand>
    {
        private readonly IRepository<Payment> _paymentRepository;
        public CreatePaymentCommandHandler(IRepository<Payment> paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        public async Task Handle(CreatePaymentCommand command, CancellationToken cancellationToken)
        {
            var payment = new Payment
            {
                Id = Guid.NewGuid(),
                UserId = command.UserId,
                Amount = command.Amount,
                CreatedAt = DateTime.UtcNow
            };
            await _paymentRepository.AddAsync(payment);
        }
    }
}
