namespace DropshippingAdmin.Core.Domain.Rules
{
    public interface IBusinessRule
    {
        bool IsBroken();
        string Message { get; }
    }
}
