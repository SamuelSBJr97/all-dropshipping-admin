namespace DropshippingAdmin.Core.Contracts
{
    public interface ITransactionService
    {
        Task<Guid> CreateTransactionAsync(Guid paymentId, string gateway);
        Task<bool> ConfirmTransactionAsync(Guid transactionId);
    }
}
