namespace DropshippingAdmin.Core.Application.Handlers
{
    public interface IQueryHandler<TQuery, TResult> where TQuery : class
    {
        Task<TResult> Handle(TQuery query, CancellationToken cancellationToken);
    }
}
