using DropshippingAdmin.Core.Domain.Rules;

namespace DropshippingAdmin.Core.Domain.Rules
{
    public class EmailMustBeUniqueRule : IBusinessRule
    {
        private readonly Func<string, bool> _emailExists;
        private readonly string _email;
        public EmailMustBeUniqueRule(string email, Func<string, bool> emailExists)
        {
            _email = email;
            _emailExists = emailExists;
        }
        public bool IsBroken() => _emailExists(_email);
        public string Message => $"Email '{_email}' já está em uso.";
    }
}
