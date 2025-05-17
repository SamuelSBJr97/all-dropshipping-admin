namespace DropshippingAdmin.Domain;

public partial class MessagesStatus
{
    public Guid Id { get; set; }

    public string Status { get; set; }

    public DateTime? SentAt { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
}