using System.Threading;
using System.Threading.Tasks;
using DropshippingAdmin.Core.Application.Commands;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Infrastructure.Repositories;
using MediatR;

namespace DropshippingAdmin.Core.Application.Handlers.Commands
{
    public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, Payment>
    {
        private readonly IPaymentRepository _paymentRepository;
        public CreatePaymentCommandHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<Payment> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
        {
            var payment = new Payment
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                Amount = request.Amount,
                CreatedAt = DateTime.UtcNow
            };
            await _paymentRepository.AddAsync(payment);
            return payment;
        }
    }
}
