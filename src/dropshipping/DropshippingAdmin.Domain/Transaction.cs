namespace DropshippingAdmin.Domain;

public partial class Transaction
{
    public Guid Id { get; set; }

    public string TransactionId { get; set; }

    public Guid PaymentId { get; set; }

    public string Gateway { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Payment Payment { get; set; }
}