using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Domain.ValueObjects;

namespace DropshippingAdmin.Core.Domain.Aggregates
{
    public class UserAggregate
    {
        public User User { get; set; }
        public List<Notification> Notifications { get; set; } = new();
        public List<Payment> Payments { get; set; } = new();
        public List<Transaction> Transactions { get; set; } = new();
        public List<WhatsAppMessage> WhatsAppMessages { get; set; } = new();
        public UserAggregate(User user)
        {
            User = user;
        }
    }
}
