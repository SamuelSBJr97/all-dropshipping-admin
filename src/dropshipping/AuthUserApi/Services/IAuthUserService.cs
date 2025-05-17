using InfrastructureService.Domain;

namespace DropshippingAdmin.Services
{
    public interface IAuthUserService
    {
        Task<User?> Authenticate(string email, string password);
        Task<User?> GetById(Guid id);
    }
}
