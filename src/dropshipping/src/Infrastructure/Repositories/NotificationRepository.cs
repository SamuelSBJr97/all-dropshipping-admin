using DropshippingAdmin.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly Data.DropshippingAdminDbContext _context;
        public NotificationRepository(Data.DropshippingAdminDbContext context)
        {
            _context = context;
        }

        public async Task<Notification?> GetByIdAsync(Guid id)
            => await _context.Notifications.FindAsync(id);

        public async Task<IEnumerable<Notification>> GetAllAsync()
            => await _context.Notifications.ToListAsync();

        public async Task AddAsync(Notification notification)
        {
            await _context.Notifications.AddAsync(notification);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Notification notification)
        {
            _context.Notifications.Update(notification);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.Notifications.FindAsync(id);
            if (entity != null)
            {
                _context.Notifications.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
