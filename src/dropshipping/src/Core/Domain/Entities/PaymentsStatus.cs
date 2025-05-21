namespace DropshippingAdmin.Core.Domain.Entities
{
    public class PaymentsStatus
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime? CreatedAt { get; set; }
    }
}
