namespace DropshippingAdmin.Core.Domain.Entities
{
    public class WhatsAppMessagesStatus
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime? SentAt { get; set; }
    }
}
