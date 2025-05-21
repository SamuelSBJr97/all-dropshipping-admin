using DropshippingAdmin.Core.Application.Queries;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace DropshippingAdmin.Core.Application.Handlers
{
    public class GetPaymentByIdQueryHandler : IQueryHandler<GetPaymentByIdQuery, Payment>
    {
        private readonly IRepository<Payment> _paymentRepository;
        public GetPaymentByIdQueryHandler(IRepository<Payment> paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        public async Task<Payment> Handle(GetPaymentByIdQuery query, CancellationToken cancellationToken)
        {
            return await _paymentRepository.GetByIdAsync(query.Id);
        }
    }
}
