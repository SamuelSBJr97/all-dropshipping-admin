using DropshippingAdmin.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public class WhatsAppMessageRepository : IWhatsAppMessageRepository
    {
        private readonly Data.DropshippingAdminDbContext _context;
        public WhatsAppMessageRepository(Data.DropshippingAdminDbContext context)
        {
            _context = context;
        }

        public async Task<WhatsAppMessage?> GetByIdAsync(Guid id)
            => await _context.WhatsAppMessages.FindAsync(id);

        public async Task<IEnumerable<WhatsAppMessage>> GetAllAsync()
            => await _context.WhatsAppMessages.ToListAsync();

        public async Task AddAsync(WhatsAppMessage message)
        {
            await _context.WhatsAppMessages.AddAsync(message);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(WhatsAppMessage message)
        {
            _context.WhatsAppMessages.Update(message);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.WhatsAppMessages.FindAsync(id);
            if (entity != null)
            {
                _context.WhatsAppMessages.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
