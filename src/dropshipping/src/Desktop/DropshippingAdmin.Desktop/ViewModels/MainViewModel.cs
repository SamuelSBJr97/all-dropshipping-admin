using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DropshippingAdmin.Desktop.Services;

namespace DropshippingAdmin.Desktop.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly ApiService _apiService;
        private string _healthStatus = "";
        public string HealthStatus
        {
            get => _healthStatus;
            set { _healthStatus = value; OnPropertyChanged(); }
        }
        public MainViewModel(ApiService apiService)
        {
            _apiService = apiService;
        }
        public async Task CheckHealthAsync()
        {
            HealthStatus = await _apiService.GetHealthAsync();
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
