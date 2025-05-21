namespace DropshippingAdmin.Core.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public string TransactionId { get; set; } = string.Empty;
        public Guid PaymentId { get; set; }
        public string Gateway { get; set; } = string.Empty;
        public DateTime? CreatedAt { get; set; }
    }
}
