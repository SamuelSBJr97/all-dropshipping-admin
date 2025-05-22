using DropshippingAdmin.Core.Contracts;
using System.Threading.Tasks;
using DropshippingAdmin.Core.Entities; // Adicione esta linha
using DropshippingAdmin.Core.Repositories; // Adicione esta linha

namespace DropshippingAdmin.Infrastructure.Services
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository; // Adicione esta linha

        public NotificationService(INotificationRepository notificationRepository) // Adicione esta linha
        {
            _notificationRepository = notificationRepository;
        }

        public async Task SendNotificationAsync(Guid userId, string type, string content)
        {
            var notification = new Notification
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                Type = type,
                Content = content,
                SentAt = DateTime.UtcNow
            };
            await _notificationRepository.AddAsync(notification);
        }
    }
}
