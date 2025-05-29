using System.Threading;
using System.Threading.Tasks;
using DropshippingAdmin.Core.Application.Commands;
using DropshippingAdmin.Infrastructure.Repositories;
using MediatR;

namespace DropshippingAdmin.Core.Application.Handlers.Commands
{
    public class DeletePaymentCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public DeletePaymentCommand(Guid id) => Id = id;
    }

    public class DeletePaymentCommandHandler : IRequestHandler<DeletePaymentCommand, bool>
    {
        private readonly IPaymentRepository _paymentRepository;
        public DeletePaymentCommandHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<bool> Handle(DeletePaymentCommand request, CancellationToken cancellationToken)
        {
            await _paymentRepository.DeleteAsync(request.Id);
            return true;
        }
    }
}
