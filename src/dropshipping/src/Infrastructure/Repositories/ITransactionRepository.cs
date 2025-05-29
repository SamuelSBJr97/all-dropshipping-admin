using DropshippingAdmin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public interface ITransactionRepository
    {
        Task<Transaction?> GetByIdAsync(Guid id);
        Task<IEnumerable<Transaction>> GetAllAsync();
        Task AddAsync(Transaction transaction);
        Task UpdateAsync(Transaction transaction);
        Task DeleteAsync(Guid id);
    }
}
