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
    }
}
