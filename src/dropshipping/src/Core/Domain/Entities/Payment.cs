namespace DropshippingAdmin.Core.Domain.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public decimal Amount { get; set; }
        public Guid? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
