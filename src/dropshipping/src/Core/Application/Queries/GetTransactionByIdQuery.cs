using DropshippingAdmin.Core.Domain.Entities;

namespace DropshippingAdmin.Core.Application.Queries
{
    public class GetTransactionByIdQuery : IQuery<Transaction>
    {
        public Guid Id { get; set; }
        public GetTransactionByIdQuery(Guid id) => Id = id;
    }
}
