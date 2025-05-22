namespace DropshippingAdmin.Core.Domain.ValueObjects
{
    public record CpfCnpj(string Value)
    {
        public static implicit operator string(CpfCnpj cpfCnpj) => cpfCnpj.Value;
        public override string ToString() => Value;
        public static CpfCnpj Create(string value)
        {
            // Validação simplificada
            if (string.IsNullOrWhiteSpace(value) || (value.Length != 11 && value.Length != 14))
                throw new ArgumentException("CPF ou CNPJ inválido");
            return new CpfCnpj(value);
        }
    }
}
