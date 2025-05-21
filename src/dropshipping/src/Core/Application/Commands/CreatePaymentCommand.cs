namespace DropshippingAdmin.Core.Application.Commands
{
    public class CreatePaymentCommand : ICommand
    {
        public Guid UserId { get; set; }
        public decimal Amount { get; set; }
    }
}
