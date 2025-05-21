namespace DropshippingAdmin.Core.Domain.ValueObjects
{
    public record Email(string Value)
    {
        public static implicit operator string(Email email) => email.Value;
        public override string ToString() => Value;
        public static Email Create(string value)
        {
            // Adicione validação de e-mail real aqui
            if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                throw new ArgumentException("Invalid email address");
            return new Email(value);
        }
    }
}
