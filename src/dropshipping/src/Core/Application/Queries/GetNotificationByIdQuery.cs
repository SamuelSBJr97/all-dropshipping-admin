using DropshippingAdmin.Core.Domain.Entities;

namespace DropshippingAdmin.Core.Application.Queries
{
    public class GetNotificationByIdQuery : IQuery<Notification>
    {
        public Guid Id { get; set; }
        public GetNotificationByIdQuery(Guid id) => Id = id;
    }
}
