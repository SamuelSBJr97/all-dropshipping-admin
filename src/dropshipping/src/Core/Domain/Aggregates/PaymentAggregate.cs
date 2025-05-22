using DropshippingAdmin.Core.Domain.Entities;
using System.Collections.Generic;

namespace DropshippingAdmin.Core.Domain.Aggregates
{
    public class PaymentAggregate
    {
        public Payment Payment { get; set; }
        public List<Transaction> Transactions { get; set; } = new();
        public PaymentAggregate(Payment payment)
        {
            Payment = payment;
        }
    }
}
