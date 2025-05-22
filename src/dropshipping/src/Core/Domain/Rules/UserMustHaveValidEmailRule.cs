using DropshippingAdmin.Core.Domain.Rules;
using DropshippingAdmin.Core.Domain.Entities;

namespace DropshippingAdmin.Core.Domain.Rules
{
    public class UserMustHaveValidEmailRule : IBusinessRule
    {
        private readonly User _user;
        public UserMustHaveValidEmailRule(User user)
        {
            _user = user;
        }
        public bool IsBroken() => string.IsNullOrWhiteSpace(_user.Email) || !_user.Email.Contains("@");
        public string Message => "Usuário deve ter um e-mail válido.";
    }
}
