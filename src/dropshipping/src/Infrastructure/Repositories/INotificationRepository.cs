using DropshippingAdmin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public interface INotificationRepository
    {
        Task<Notification?> GetByIdAsync(Guid id);
        Task<IEnumerable<Notification>> GetAllAsync();
        Task AddAsync(Notification notification);
        Task UpdateAsync(Notification notification);
        Task DeleteAsync(Guid id);
    }
}
