using DropshippingAdmin.Core.Domain.Entities;

namespace DropshippingAdmin.Core.Domain.Events
{
    public class NotificationSentEvent : DomainEvent
    {
        public Notification Notification { get; }
        public NotificationSentEvent(Notification notification)
        {
            Notification = notification;
        }
    }
}
