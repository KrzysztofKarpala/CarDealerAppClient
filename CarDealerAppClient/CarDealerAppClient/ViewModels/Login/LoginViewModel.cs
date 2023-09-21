using CarDealerAppClient.Services.Navigation;
using CarDealerAppClient.ViewModels.Base;

namespace CarDealerAppClient.ViewModels.Login
{
    public class LoginViewModel : BaseViewModel, ILoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
        public async Task NavigateToHome()
        {
            await _navigationService.NavigateAsync("/");
        }
    }
}
