namespace DropshippingAdmin.Core.Application.Commands
{
    public class CreateTransactionCommand : ICommand
    {
        public string TransactionId { get; set; } = string.Empty;
        public Guid PaymentId { get; set; }
        public string Gateway { get; set; } = string.Empty;
    }
}
