namespace DropshippingAdmin.Core.Application.Events
{
    public abstract class IntegrationEvent
    {
        public DateTime OccurredOn { get; protected set; } = DateTime.UtcNow;
    }
}
