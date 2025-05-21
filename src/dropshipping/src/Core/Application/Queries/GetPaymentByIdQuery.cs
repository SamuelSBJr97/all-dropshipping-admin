using DropshippingAdmin.Core.Domain.Entities;

namespace DropshippingAdmin.Core.Application.Queries
{
    public class GetPaymentByIdQuery : IQuery<Payment>
    {
        public Guid Id { get; set; }
        public GetPaymentByIdQuery(Guid id) => Id = id;
    }
}
