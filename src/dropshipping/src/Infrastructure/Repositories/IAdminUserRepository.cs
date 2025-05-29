using DropshippingAdmin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public interface IAdminUserRepository
    {
        Task<AdminUser?> GetByIdAsync(Guid id);
        Task<IEnumerable<AdminUser>> GetAllAsync();
        Task AddAsync(AdminUser adminUser);
        Task UpdateAsync(AdminUser adminUser);
        Task DeleteAsync(Guid id);
    }
}
