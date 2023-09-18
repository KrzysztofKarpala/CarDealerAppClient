using CarDealerAppClient.Services.Navigation;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CarDealerAppClient.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public INavigationService _navigationService { get; set; }
        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
