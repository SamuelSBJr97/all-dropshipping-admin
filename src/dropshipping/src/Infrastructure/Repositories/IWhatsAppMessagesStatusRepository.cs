using DropshippingAdmin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public interface IWhatsAppMessagesStatusRepository
    {
        Task<WhatsAppMessagesStatus?> GetByIdAsync(Guid id);
        Task<IEnumerable<WhatsAppMessagesStatus>> GetAllAsync();
        Task AddAsync(WhatsAppMessagesStatus status);
        Task UpdateAsync(WhatsAppMessagesStatus status);
        Task DeleteAsync(Guid id);
    }
}
