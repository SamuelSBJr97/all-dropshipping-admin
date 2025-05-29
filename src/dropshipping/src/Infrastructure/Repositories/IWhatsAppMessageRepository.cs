using DropshippingAdmin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public interface IWhatsAppMessageRepository
    {
        Task<WhatsAppMessage?> GetByIdAsync(Guid id);
        Task<IEnumerable<WhatsAppMessage>> GetAllAsync();
        Task AddAsync(WhatsAppMessage message);
        Task UpdateAsync(WhatsAppMessage message);
        Task DeleteAsync(Guid id);
    }
}
