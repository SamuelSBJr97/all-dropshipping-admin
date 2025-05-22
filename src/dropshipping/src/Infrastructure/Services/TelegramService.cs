using DropshippingAdmin.Core.Contracts;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DropshippingAdmin.Infrastructure.Services
{
    public class TelegramService : ITelegramService
    {
        private readonly HttpClient _httpClient;
        private readonly string _botToken;
        public TelegramService(HttpClient httpClient, string botToken)
        {
            _httpClient = httpClient;
            _botToken = botToken;
        }
        public async Task SendMessageAsync(long chatId, string message)
        {
            var url = $"https://api.telegram.org/bot{_botToken}/sendMessage?chat_id={chatId}&text={System.Net.WebUtility.UrlEncode(message)}";
            await _httpClient.GetAsync(url);
        }
    }
}
