namespace DropshippingAdmin.Core.Application.Dtos
{
    public class NotificationDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime? SentAt { get; set; }
    }
}