using DropshippingAdmin.Core.Application.Queries;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace DropshippingAdmin.Core.Application.Handlers
{
    public class GetAdminUserByIdQueryHandler : IQueryHandler<GetAdminUserByIdQuery, AdminUser>
    {
        private readonly IRepository<AdminUser> _adminUserRepository;
        public GetAdminUserByIdQueryHandler(IRepository<AdminUser> adminUserRepository)
        {
            _adminUserRepository = adminUserRepository;
        }
        public async Task<AdminUser> Handle(GetAdminUserByIdQuery query, CancellationToken cancellationToken)
        {
            return await _adminUserRepository.GetByIdAsync(query.Id);
        }
    }
}
