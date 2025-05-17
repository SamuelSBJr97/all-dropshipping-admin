namespace AdminApi.Domain
{
    public class Admin
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public bool? TwoFactorEnabled { get; set; }

        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<User> Notifications { get; set; } = new List<User>();
        public string Token { get; internal set; }
    }
}
