using DropshippingAdmin.Core.Contracts;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Domain.Repositories;
using DropshippingAdmin.Core.Shared.Utils;
using Microsoft.EntityFrameworkCore;

namespace DropshippingAdmin.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> EmailExistsAsync(string email)
        {
            var users = await _userRepository.GetAllAsync();
            return users.Any(u => u.Email == email);
        }
        public async Task<Guid> CreateUserAsync(string name, string email, string password)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = name,
                Email = email,
                PasswordHash = PasswordHasher.Hash(password),
                CreatedAt = DateTime.UtcNow
            };
            await _userRepository.AddAsync(user);
            return user.Id;
        }
        public async Task DeleteUserAsync(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user != null)
                await _userRepository.DeleteAsync(user);
        }
    }
}
