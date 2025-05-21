using DropshippingAdmin.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DropshippingAdmin.Infrastructure.Data.Context
{
    public class DropshippingAdminDbContext : DbContext
    {
        public DropshippingAdminDbContext(DbContextOptions<DropshippingAdminDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<AdminUser> AdminUsers => Set<AdminUser>();
        public DbSet<Notification> Notifications => Set<Notification>();
        public DbSet<Payment> Payments => Set<Payment>();
        public DbSet<PaymentsStatus> PaymentsStatus => Set<PaymentsStatus>();
        public DbSet<Transaction> Transactions => Set<Transaction>();
        public DbSet<WhatsAppMessage> WhatsAppMessages => Set<WhatsAppMessage>();
        public DbSet<WhatsAppMessagesStatus> WhatsAppMessagesStatus => Set<WhatsAppMessagesStatus>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Adicione configurações específicas aqui
            base.OnModelCreating(modelBuilder);
        }
    }
}
