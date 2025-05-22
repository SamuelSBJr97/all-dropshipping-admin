using StackExchange.Redis;
using System.Text.Json;

namespace DropshippingAdmin.Api.Auth.Services
{
    public class RedisAuthSessionService
    {
        private readonly IDatabase _db;
        public RedisAuthSessionService(IConnectionMultiplexer redis)
        {
            _db = redis.GetDatabase();
        }
        public async Task StoreSessionAsync(string token, AuthSession session, TimeSpan? expiry = null)
        {
            var json = JsonSerializer.Serialize(session);
            await _db.StringSetAsync($"auth:{token}", json, expiry ?? TimeSpan.FromHours(2));
        }
        public async Task<AuthSession?> GetSessionAsync(string token)
        {
            var json = await _db.StringGetAsync($"auth:{token}");
            if (json.IsNullOrEmpty) return null;
            return JsonSerializer.Deserialize<AuthSession>(json!);
        }
    }

    public class AuthSession
    {
        public string UserId { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string[] Roles { get; set; } = Array.Empty<string>();
        public string[] Permissions { get; set; } = Array.Empty<string>();
    }
}
