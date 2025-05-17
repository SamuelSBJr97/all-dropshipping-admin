using InfrastructureService.Domain;
using Microsoft.EntityFrameworkCore;

namespace DropshippingAdmin.Infrastructure
{
    public class DropshippingAdminContext(DbContextOptions<DropshippingAdminContext> options) : DbContext(options)
    {

        // Adicione DbSets para suas entidades aqui
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<InfrastructureService.Domain.MessagesStatus> MessagesStatus { get; set; } = default!;
        public DbSet<InfrastructureService.Domain.PaymentsStatus> PaymentsStatus { get; set; } = default!;
    }
}