namespace DropshippingAdmin.Core.Application.Dtos
{
    public class AdminUserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public string? Email { get; set; }
    }
}
