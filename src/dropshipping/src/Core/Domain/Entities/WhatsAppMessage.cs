namespace DropshippingAdmin.Core.Domain.Entities
{
    public class WhatsAppMessage
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string MessageContent { get; set; } = string.Empty;
        public DateTime? SentAt { get; set; }
        public Guid? Status { get; set; }
    }
}
