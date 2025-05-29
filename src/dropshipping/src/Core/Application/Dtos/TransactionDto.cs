namespace DropshippingAdmin.Core.Application.Dtos
{
    public class TransactionDto
    {
        public Guid Id { get; set; }
        public string TransactionId { get; set; } = string.Empty;
        public Guid PaymentId { get; set; }
        public string Gateway { get; set; } = string.Empty;
        public DateTime? CreatedAt { get; set; }
    }
}