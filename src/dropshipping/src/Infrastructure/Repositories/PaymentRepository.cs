using DropshippingAdmin.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly Data.DropshippingAdminDbContext _context;
        public PaymentRepository(Data.DropshippingAdminDbContext context)
        {
            _context = context;
        }

        public async Task<Payment?> GetByIdAsync(Guid id)
            => await _context.Payments.FindAsync(id);

        public async Task<IEnumerable<Payment>> GetAllAsync()
            => await _context.Payments.ToListAsync();

        public async Task AddAsync(Payment payment)
        {
            await _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Payment payment)
        {
            _context.Payments.Update(payment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.Payments.FindAsync(id);
            if (entity != null)
            {
                _context.Payments.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
