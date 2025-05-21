using DropshippingAdmin.Core.Application.Commands;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace DropshippingAdmin.Core.Application.Handlers
{
    public class CreateNotificationCommandHandler : ICommandHandler<CreateNotificationCommand>
    {
        private readonly IRepository<Notification> _notificationRepository;
        public CreateNotificationCommandHandler(IRepository<Notification> notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }
        public async Task Handle(CreateNotificationCommand command, CancellationToken cancellationToken)
        {
            var notification = new Notification
            {
                Id = Guid.NewGuid(),
                UserId = command.UserId,
                Type = command.Type,
                Content = command.Content,
                SentAt = DateTime.UtcNow
            };
            await _notificationRepository.AddAsync(notification);
        }
    }
}
