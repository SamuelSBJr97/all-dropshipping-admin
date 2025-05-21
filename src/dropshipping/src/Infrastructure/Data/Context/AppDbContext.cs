using DropshippingAdmin.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DropshippingAdmin.Infrastructure.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentsStatus> PaymentsStatus { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<WhatsAppMessage> WhatsAppMessages { get; set; }
        public DbSet<WhatsAppMessagesStatus> WhatsAppMessagesStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações com Fluent API podem ser adicionadas aqui
            base.OnModelCreating(modelBuilder);
        }
    }
}
