namespace DropshippingAdmin.Core.Application.Dtos
{
    public class PaymentDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public decimal Amount { get; set; }
        public Guid? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}