namespace DropshippingAdmin.Core.Application.Dtos
{
    public class PaymentsStatusDto
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime? CreatedAt { get; set; }
    }
}