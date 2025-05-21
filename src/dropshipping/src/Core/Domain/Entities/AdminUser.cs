namespace DropshippingAdmin.Core.Domain.Entities
{
    public class AdminUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public string SecretHash { get; set; } = string.Empty;
        public bool TwoFactorEnabled { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? Email { get; set; }
    }
}
