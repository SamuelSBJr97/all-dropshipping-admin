using DropshippingAdmin.Core.Application.Commands;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace DropshippingAdmin.Core.Application.Handlers
{
    public class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
    {
        private readonly IRepository<User> _userRepository;
        public DeleteUserCommandHandler(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task Handle(DeleteUserCommand command, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(command.Id);
            if (user == null) throw new Exception("User not found");
            await _userRepository.DeleteAsync(user);
        }
    }
}
