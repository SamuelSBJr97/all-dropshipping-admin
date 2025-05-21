using DropshippingAdmin.Core.Application.Queries;
using DropshippingAdmin.Core.Domain.Entities;
using DropshippingAdmin.Core.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace DropshippingAdmin.Core.Application.Handlers
{
    public class GetTransactionByIdQueryHandler : IQueryHandler<GetTransactionByIdQuery, Transaction>
    {
        private readonly IRepository<Transaction> _transactionRepository;
        public GetTransactionByIdQueryHandler(IRepository<Transaction> transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        public async Task<Transaction> Handle(GetTransactionByIdQuery query, CancellationToken cancellationToken)
        {
            return await _transactionRepository.GetByIdAsync(query.Id);
        }
    }
}
