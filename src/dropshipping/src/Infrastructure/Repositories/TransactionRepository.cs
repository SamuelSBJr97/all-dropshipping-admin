using DropshippingAdmin.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly Data.DropshippingAdminDbContext _context;
        public TransactionRepository(Data.DropshippingAdminDbContext context)
        {
            _context = context;
        }

        public async Task<Transaction?> GetByIdAsync(Guid id)
            => await _context.Transactions.FindAsync(id);

        public async Task<IEnumerable<Transaction>> GetAllAsync()
            => await _context.Transactions.ToListAsync();

        public async Task AddAsync(Transaction transaction)
        {
            await _context.Transactions.AddAsync(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Transaction transaction)
        {
            _context.Transactions.Update(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.Transactions.FindAsync(id);
            if (entity != null)
            {
                _context.Transactions.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
