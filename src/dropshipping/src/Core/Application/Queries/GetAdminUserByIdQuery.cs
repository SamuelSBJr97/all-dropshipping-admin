using DropshippingAdmin.Core.Domain.Entities;

namespace DropshippingAdmin.Core.Application.Queries
{
    public class GetAdminUserByIdQuery : IQuery<AdminUser>
    {
        public Guid Id { get; set; }
        public GetAdminUserByIdQuery(Guid id) => Id = id;
    }
}
