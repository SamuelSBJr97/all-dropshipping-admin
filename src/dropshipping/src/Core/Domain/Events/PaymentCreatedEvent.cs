using DropshippingAdmin.Core.Domain.Entities;

namespace DropshippingAdmin.Core.Domain.Events
{
    public class PaymentCreatedEvent : DomainEvent
    {
        public Payment Payment { get; }
        public PaymentCreatedEvent(Payment payment)
        {
            Payment = payment;
        }
    }
}
