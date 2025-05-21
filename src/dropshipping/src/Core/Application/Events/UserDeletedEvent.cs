using DropshippingAdmin.Core.Domain.Entities;

namespace DropshippingAdmin.Core.Application.Events
{
    public class UserDeletedEvent : IntegrationEvent
    {
        public User User { get; }
        public UserDeletedEvent(User user)
        {
            User = user;
        }
    }
}
