namespace DropshippingAdmin.Core.Contracts
{
    public interface IUserService
    {
        Task<bool> EmailExistsAsync(string email);
        Task<Guid> CreateUserAsync(string name, string email, string password);
        Task DeleteUserAsync(Guid id);
    }
}
