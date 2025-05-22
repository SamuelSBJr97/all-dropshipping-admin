using Microsoft.AspNetCore.Mvc;
using DropshippingAdmin.Core.Contracts;
using OtpNet;
using DropshippingAdmin.Api.Auth.Services;

namespace DropshippingAdmin.Api.Auth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly RedisAuthSessionService _sessionService;
        public AuthController(IUserService userService, RedisAuthSessionService sessionService)
        {
            _userService = userService;
            _sessionService = sessionService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            // 1. Validar usuário
            var userExists = await _userService.EmailExistsAsync(request.Email);
            if (!userExists)
                return Unauthorized("Usuário ou senha inválidos");
            // 2. Simular busca de usuário e validação de senha (substitua por busca real)
            // Exemplo: var user = await _userService.GetByEmailAsync(request.Email);
            // if (!PasswordHasher.Verify(request.Password, user.PasswordHash))
            //     return Unauthorized("Usuário ou senha inválidos");
            // 3. Simular que o usuário tem MFA habilitado
            var mfaEnabled = true; // Substitua por user.TwoFactorEnabled
            if (mfaEnabled)
            {
                // Gerar secret MFA (em produção, salve no usuário)
                var secret = KeyGeneration.GenerateRandomKey(20);
                var base32Secret = Base32Encoding.ToString(secret);
                // Gerar código TOTP
                var totp = new Totp(secret);
                var code = totp.ComputeTotp();
                // Em produção, envie o código por e-mail, SMS, etc.
                System.Console.WriteLine($"[MFA] Código TOTP para {request.Email}: {code}");
                return Ok(new { mfaRequired = true, secret = base32Secret, message = "MFA necessário. Envie o código do autenticador." });
            }
            // 4. Gerar JWT se não precisar de MFA
            var token = "jwt-token-mock"; // Substitua por geração real
            var session = new AuthSession
            {
                UserId = "user-id-mock", // Substitua por user real
                Email = request.Email,
                Roles = new[] { "User" },
                Permissions = new[] { "read", "write" }
            };
            await _sessionService.StoreSessionAsync(token, session);
            return Ok(new { token });
        }

        [HttpPost("mfa")]
        public async Task<IActionResult> Mfa([FromBody] MfaRequest request)
        {
            // Validar código TOTP
            var secret = Base32Encoding.ToBytes(request.Secret);
            var totp = new Totp(secret);
            var isValid = totp.VerifyTotp(request.Code, out long timeStepMatched, VerificationWindow.RfcSpecifiedNetworkDelay);
            if (!isValid)
                return Unauthorized("Código MFA inválido");
            // 2. Gerar JWT após MFA
            var token = "jwt-token-mock"; // Substitua por geração real
            var session = new AuthSession
            {
                UserId = request.UserId,
                Email = request.Email,
                Roles = new[] { "User" },
                Permissions = new[] { "read", "write" }
            };
            await _sessionService.StoreSessionAsync(token, session);
            return Ok(new { token });
        }
    }

    public class LoginRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class MfaRequest
    {
        public string UserId { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Secret { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
}
