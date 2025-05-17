using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropshippingAdmin.Domain
{
    public class Login
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? Token { get; set; } = null;
        public string? RefreshToken { get; set; } = null;
        public DateTime? ExpirationDate { get; set; } = null;
        public bool IsAuthenticated { get; set; } = false;
        public bool IsBlocked { get; set; } = false;
        public bool IsExpired { get; set; } = false;
        public bool IsTwoFactorEnabled { get; set; } = false;
    }
}
