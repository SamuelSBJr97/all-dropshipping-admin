using DropshippingAdmin.Core.Domain.Entities;

namespace DropshippingAdmin.Core.Domain.Events
{
    public class UserCreatedEvent : DomainEvent
    {
        public User User { get; }
        public UserCreatedEvent(User user)
        {
            User = user;
        }
    }
}
