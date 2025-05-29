using DropshippingAdmin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public interface IPaymentRepository
    {
        Task<Payment?> GetByIdAsync(Guid id);
        Task<IEnumerable<Payment>> GetAllAsync();
        Task AddAsync(Payment payment);
        Task UpdateAsync(Payment payment);
        Task DeleteAsync(Guid id);
    }
}
