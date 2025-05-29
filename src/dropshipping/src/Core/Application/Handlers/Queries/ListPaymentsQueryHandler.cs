using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Infrastructure.Repositories;
using MediatR;

namespace DropshippingAdmin.Core.Application.Handlers.Queries
{
    public class ListPaymentsQuery : IRequest<IEnumerable<Payment>> { }

    public class ListPaymentsQueryHandler : IRequestHandler<ListPaymentsQuery, IEnumerable<Payment>>
    {
        private readonly IPaymentRepository _paymentRepository;
        public ListPaymentsQueryHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<IEnumerable<Payment>> Handle(ListPaymentsQuery request, CancellationToken cancellationToken)
        {
            return await _paymentRepository.GetAllAsync();
        }
    }
}
