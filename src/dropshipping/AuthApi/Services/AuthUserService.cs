using DropshippingAdmin.Auth.Domain;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace DropshippingAdmin.Auth.Services
{
    public class AuthUserService(IConfiguration configuration) : IAuthUserService
    {
        public string Secret { get; } = configuration.GetValue<string>("JwtSecret") ?? throw new ArgumentNullException(nameof(configuration));

        public async Task<User?> Authenticate(string email, string password)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Email == email);

            if (user == null || !VerifyPasswordHash(password, user.PasswordHash))
                return null;

            // Autenticação bem-sucedida, gere o token JWT
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity([new Claim("id", user.Id.ToString())]),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            // Remova a senha antes de retornar
            user.PasswordHash = null;

            return user;
        }

        public async Task<User?> GetById(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }

        private static bool VerifyPasswordHash(string password, string storedHash)
        {
            var hashBytes = Convert.FromBase64String(storedHash);
            var salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            using Rfc2898DeriveBytes pbkdf2 = new(password, salt, 100000, HashAlgorithmName.SHA256);
            var hash = pbkdf2.GetBytes(20);
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                    return false;
            }
            return true;
        }
    }
}
