namespace DropshippingAdmin.Core.Domain.ValueObjects
{
    public record PhoneNumber(string Value)
    {
        public static implicit operator string(PhoneNumber phone) => phone.Value;
        public override string ToString() => Value;
        public static PhoneNumber Create(string value)
        {
            // Validação simplificada
            if (string.IsNullOrWhiteSpace(value) || value.Length < 8)
                throw new ArgumentException("Telefone inválido");
            return new PhoneNumber(value);
        }
    }
}
