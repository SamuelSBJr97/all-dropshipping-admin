namespace DropshippingAdmin.Core.Contracts
{
    public interface IPaymentService
    {
        Task<Guid> CreatePaymentAsync(Guid userId, decimal amount);
        Task<bool> ConfirmPaymentAsync(Guid paymentId);
    }
}
