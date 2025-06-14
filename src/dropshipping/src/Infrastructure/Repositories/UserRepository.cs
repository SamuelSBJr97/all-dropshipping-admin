using DropshippingAdmin.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Data.DropshippingAdminDbContext _context;
        public UserRepository(Data.DropshippingAdminDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetByIdAsync(Guid id)
            => await _context.Users.FindAsync(id);

        public async Task<IEnumerable<User>> GetAllAsync()
            => await _context.Users.ToListAsync();

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.Users.FindAsync(id);
            if (entity != null)
            {
                _context.Users.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
