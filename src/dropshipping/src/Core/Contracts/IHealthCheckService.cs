namespace DropshippingAdmin.Core.Contracts
{
    public interface IHealthCheckService
    {
        Task<bool> IsHealthyAsync();
    }
}
