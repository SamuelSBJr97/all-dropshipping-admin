using System.Threading.Tasks;
using DropshippingAdmin.Infrastructure.Data;

namespace DropshippingAdmin.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DropshippingAdminDbContext _context;
        public IPaymentRepository Payments { get; }
        public IUserRepository Users { get; }
        public INotificationRepository Notifications { get; }
        public ITransactionRepository Transactions { get; }
        public IAdminUserRepository AdminUsers { get; }
        public IWhatsAppMessageRepository WhatsAppMessages { get; }
        public IWhatsAppMessagesStatusRepository WhatsAppMessagesStatus { get; }
        // Adicione outros repositórios aqui

        public UnitOfWork(DropshippingAdminDbContext context, IPaymentRepository paymentRepository, IUserRepository userRepository, INotificationRepository notificationRepository, ITransactionRepository transactionRepository, IAdminUserRepository adminUserRepository, IWhatsAppMessageRepository whatsAppMessageRepository, IWhatsAppMessagesStatusRepository whatsAppMessagesStatusRepository)
        {
            _context = context;
            Payments = paymentRepository;
            Users = userRepository;
            Notifications = notificationRepository;
            Transactions = transactionRepository;
            AdminUsers = adminUserRepository;
            WhatsAppMessages = whatsAppMessageRepository;
            WhatsAppMessagesStatus = whatsAppMessagesStatusRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
