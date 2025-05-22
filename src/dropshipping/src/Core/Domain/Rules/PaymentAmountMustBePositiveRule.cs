using DropshippingAdmin.Core.Domain.Rules;

namespace DropshippingAdmin.Core.Domain.Rules
{
    public class PaymentAmountMustBePositiveRule : IBusinessRule
    {
        private readonly decimal _amount;
        public PaymentAmountMustBePositiveRule(decimal amount)
        {
            _amount = amount;
        }
        public bool IsBroken() => _amount <= 0;
        public string Message => "O valor do pagamento deve ser positivo.";
    }
}
