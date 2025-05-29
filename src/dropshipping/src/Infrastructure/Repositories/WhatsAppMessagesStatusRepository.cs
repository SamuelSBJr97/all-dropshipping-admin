using DropshippingAdmin.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public class WhatsAppMessagesStatusRepository : IWhatsAppMessagesStatusRepository
    {
        private readonly Data.DropshippingAdminDbContext _context;
        public WhatsAppMessagesStatusRepository(Data.DropshippingAdminDbContext context)
        {
            _context = context;
        }

        public async Task<WhatsAppMessagesStatus?> GetByIdAsync(Guid id)
            => await _context.WhatsAppMessagesStatus.FindAsync(id);

        public async Task<IEnumerable<WhatsAppMessagesStatus>> GetAllAsync()
            => await _context.WhatsAppMessagesStatus.ToListAsync();

        public async Task AddAsync(WhatsAppMessagesStatus status)
        {
            await _context.WhatsAppMessagesStatus.AddAsync(status);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(WhatsAppMessagesStatus status)
        {
            _context.WhatsAppMessagesStatus.Update(status);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.WhatsAppMessagesStatus.FindAsync(id);
            if (entity != null)
            {
                _context.WhatsAppMessagesStatus.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
