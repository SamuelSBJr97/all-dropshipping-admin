using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public interface IUnitOfWork
    {
        IPaymentRepository Payments { get; }
        IUserRepository Users { get; }
        INotificationRepository Notifications { get; }
        ITransactionRepository Transactions { get; }
        IAdminUserRepository AdminUsers { get; }
        IWhatsAppMessageRepository WhatsAppMessages { get; }
        IWhatsAppMessagesStatusRepository WhatsAppMessagesStatus { get; }
        // Adicione outros repositórios aqui
        Task<int> SaveChangesAsync();
    }
}
