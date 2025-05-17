using DropshippingAdmin.Auth.Domain;

namespace DropshippingAdmin.Auth.Services
{
    public interface IAuthUserService
    {
        Task<User?> Authenticate(string email, string password);
        Task<User?> GetById(Guid id);
    }
}
