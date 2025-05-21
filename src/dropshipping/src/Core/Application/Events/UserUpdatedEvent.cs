using DropshippingAdmin.Core.Domain.Entities;

namespace DropshippingAdmin.Core.Application.Events
{
    public class UserUpdatedEvent : IntegrationEvent
    {
        public User User { get; }
        public UserUpdatedEvent(User user)
        {
            User = user;
        }
    }
}
