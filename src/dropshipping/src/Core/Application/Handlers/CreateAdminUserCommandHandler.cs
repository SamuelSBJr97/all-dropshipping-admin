using DropshippingAdmin.Core.Application.Commands;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace DropshippingAdmin.Core.Application.Handlers
{
    public class CreateAdminUserCommandHandler : ICommandHandler<CreateAdminUserCommand>
    {
        private readonly IRepository<AdminUser> _adminUserRepository;
        public CreateAdminUserCommandHandler(IRepository<AdminUser> adminUserRepository)
        {
            _adminUserRepository = adminUserRepository;
        }
        public async Task Handle(CreateAdminUserCommand command, CancellationToken cancellationToken)
        {
            var admin = new AdminUser
            {
                Id = Guid.NewGuid(),
                Name = command.Name,
                Key = command.Key,
                SecretHash = command.Secret, // Hash em produção!
                CreatedAt = DateTime.UtcNow,
                Email = command.Email
            };
            await _adminUserRepository.AddAsync(admin);
        }
    }
}
