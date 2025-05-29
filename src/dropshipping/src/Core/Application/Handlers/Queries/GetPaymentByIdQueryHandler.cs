using System.Threading;
using System.Threading.Tasks;
using DropshippingAdmin.Core.Application.Queries;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Infrastructure.Repositories;
using MediatR;

namespace DropshippingAdmin.Core.Application.Handlers.Queries
{
    public class GetPaymentByIdQueryHandler : IRequestHandler<GetPaymentByIdQuery, Payment?>
    {
        private readonly IPaymentRepository _paymentRepository;
        public GetPaymentByIdQueryHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<Payment?> Handle(GetPaymentByIdQuery request, CancellationToken cancellationToken)
        {
            return await _paymentRepository.GetByIdAsync(request.Id);
        }
    }
}
