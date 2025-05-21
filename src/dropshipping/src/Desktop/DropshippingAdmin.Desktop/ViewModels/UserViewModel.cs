using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DropshippingAdmin.Desktop.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private string _name = string.Empty;
        private string _email = string.Empty;
        public string Name { get => _name; set { _name = value; OnPropertyChanged(); } }
        public string Email { get => _email; set { _email = value; OnPropertyChanged(); } }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
