using System.Threading;
using System.Threading.Tasks;
using DropshippingAdmin.Core.Application.Commands;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Infrastructure.Repositories;
using MediatR;

namespace DropshippingAdmin.Core.Application.Handlers.Commands
{
    public class UpdatePaymentCommand : IRequest<Payment?>
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public Guid? Status { get; set; }
    }

    public class UpdatePaymentCommandHandler : IRequestHandler<UpdatePaymentCommand, Payment?>
    {
        private readonly IPaymentRepository _paymentRepository;
        public UpdatePaymentCommandHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<Payment?> Handle(UpdatePaymentCommand request, CancellationToken cancellationToken)
        {
            var payment = await _paymentRepository.GetByIdAsync(request.Id);
            if (payment == null) return null;
            payment.Amount = request.Amount;
            payment.Status = request.Status;
            await _paymentRepository.UpdateAsync(payment);
            return payment;
        }
    }
}
