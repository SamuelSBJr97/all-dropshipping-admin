namespace DropshippingAdmin.Domain;

public partial class PaymentsStatus
{
    public Guid Id { get; set; }

    public string Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}