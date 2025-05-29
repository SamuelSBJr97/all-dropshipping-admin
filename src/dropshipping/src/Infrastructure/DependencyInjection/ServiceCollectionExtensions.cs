using DropshippingAdmin.Infrastructure.Data.Context;
using DropshippingAdmin.Infrastructure.Repositories;
using DropshippingAdmin.Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DropshippingAdmin.Infrastructure.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
            // Adicione outros serviços de infraestrutura aqui
            return services;
        }

        public static IServiceCollection AddDropshippingAdminServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DropshippingAdminDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IAdminUserRepository, AdminUserRepository>();
            services.AddScoped<IWhatsAppMessageRepository, WhatsAppMessageRepository>();
            services.AddScoped<IWhatsAppMessagesStatusRepository, WhatsAppMessagesStatusRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<DropshippingAdmin.Core.Application.Handlers.Commands.CreatePaymentCommandHandler>());
            services.AddAutoMapper(typeof(DropshippingAdmin.Core.Application.Mappings.PaymentProfile));

            return services;
        }
    }
}
