using System.Net.Http;
using System.Threading.Tasks;

namespace DropshippingAdmin.Desktop.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetHealthAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:5001/api/health");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
