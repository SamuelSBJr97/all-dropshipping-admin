namespace DropshippingAdmin.Domain;

public partial class Payment
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public decimal Amount { get; set; }

    public Guid? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual PaymentsStatus StatusNavigation { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual User User { get; set; }
}