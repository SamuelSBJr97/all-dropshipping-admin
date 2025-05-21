using DropshippingAdmin.Core.Application.Queries;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace DropshippingAdmin.Core.Application.Handlers
{
    public class GetNotificationByIdQueryHandler : IQueryHandler<GetNotificationByIdQuery, Notification>
    {
        private readonly IRepository<Notification> _notificationRepository;
        public GetNotificationByIdQueryHandler(IRepository<Notification> notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }
        public async Task<Notification> Handle(GetNotificationByIdQuery query, CancellationToken cancellationToken)
        {
            return await _notificationRepository.GetByIdAsync(query.Id);
        }
    }
}
