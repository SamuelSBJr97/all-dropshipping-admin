namespace DropshippingAdmin.Domain;

public partial class Notification
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string Type { get; set; }

    public string Content { get; set; }

    public DateTime? SentAt { get; set; }

    public virtual User User { get; set; }
}