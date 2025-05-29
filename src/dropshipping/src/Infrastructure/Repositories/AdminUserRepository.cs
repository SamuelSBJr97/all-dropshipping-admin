using DropshippingAdmin.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public class AdminUserRepository : IAdminUserRepository
    {
        private readonly Data.DropshippingAdminDbContext _context;
        public AdminUserRepository(Data.DropshippingAdminDbContext context)
        {
            _context = context;
        }

        public async Task<AdminUser?> GetByIdAsync(Guid id)
            => await _context.AdminUsers.FindAsync(id);

        public async Task<IEnumerable<AdminUser>> GetAllAsync()
            => await _context.AdminUsers.ToListAsync();

        public async Task AddAsync(AdminUser adminUser)
        {
            await _context.AdminUsers.AddAsync(adminUser);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(AdminUser adminUser)
        {
            _context.AdminUsers.Update(adminUser);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.AdminUsers.FindAsync(id);
            if (entity != null)
            {
                _context.AdminUsers.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
