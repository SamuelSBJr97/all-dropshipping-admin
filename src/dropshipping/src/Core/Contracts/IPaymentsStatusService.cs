namespace DropshippingAdmin.Core.Contracts
{
    public interface IPaymentsStatusService
    {
        Task UpdateStatusAsync(Guid paymentId, string status);
    }
}
