namespace DropshippingAdmin.Core.Application.Handlers
{
    public interface ICommandHandler<TCommand> where TCommand : class
    {
        Task Handle(TCommand command, CancellationToken cancellationToken);
    }
}
