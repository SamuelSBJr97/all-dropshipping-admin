using DropshippingAdmin.Core.Domain.Entities;
using System.Collections.Generic;

namespace DropshippingAdmin.Core.Domain.Aggregates
{
    public class NotificationAggregate
    {
        public Notification Notification { get; set; }
        public List<User> Recipients { get; set; } = new();
        public NotificationAggregate(Notification notification)
        {
            Notification = notification;
        }
    }
}
