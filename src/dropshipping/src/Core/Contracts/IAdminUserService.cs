namespace DropshippingAdmin.Core.Contracts
{
    public interface IAdminUserService
    {
        Task<bool> KeyExistsAsync(string key);
        Task<Guid> CreateAdminUserAsync(string name, string key, string secret, string? email);
        Task DeleteAdminUserAsync(Guid id);
    }
}
