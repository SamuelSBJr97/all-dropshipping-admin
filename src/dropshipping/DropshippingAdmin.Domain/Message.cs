namespace DropshippingAdmin.Domain;

public partial class Message
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string MessageContent { get; set; }

    public DateTime? SentAt { get; set; }

    public Guid? Status { get; set; }

    public virtual MessagesStatus StatusNavigation { get; set; }

    public virtual User User { get; set; }
}