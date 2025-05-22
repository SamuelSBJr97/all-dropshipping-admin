using DropshippingAdmin.Core.Contracts;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Domain.Repositories;
using DropshippingAdmin.Core.Shared.Utils;

namespace DropshippingAdmin.Infrastructure.Services
{
    public class AdminUserService : IAdminUserService
    {
        private readonly IRepository<AdminUser> _adminUserRepository;
        public AdminUserService(IRepository<AdminUser> adminUserRepository)
        {
            _adminUserRepository = adminUserRepository;
        }
        public async Task<bool> KeyExistsAsync(string key)
        {
            var admins = await _adminUserRepository.GetAllAsync();
            return admins.Any(a => a.Key == key);
        }
        public async Task<Guid> CreateAdminUserAsync(string name, string key, string secret, string? email)
        {
            var admin = new AdminUser
            {
                Id = Guid.NewGuid(),
                Name = name,
                Key = key,
                SecretHash = PasswordHasher.Hash(secret),
                CreatedAt = DateTime.UtcNow,
                Email = email
            };
            await _adminUserRepository.AddAsync(admin);
            return admin.Id;
        }
        public async Task DeleteAdminUserAsync(Guid id)
        {
            var admin = await _adminUserRepository.GetByIdAsync(id);
            if (admin != null)
                await _adminUserRepository.DeleteAsync(admin);
        }
    }
}
