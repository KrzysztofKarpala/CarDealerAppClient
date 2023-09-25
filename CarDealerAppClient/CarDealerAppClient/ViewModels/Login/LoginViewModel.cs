using CarDealerAppClient.Models.Login;
using CarDealerAppClient.Services.Navigation;
using CarDealerAppClient.ViewModels.Base;

namespace CarDealerAppClient.ViewModels.Login
{
    public class LoginViewModel : BaseViewModel, ILoginViewModel
    {
        public LoginModel Login { get; set; } = new LoginModel();
        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
        public async Task NavigateToHome()
        {
            await _navigationService.NavigateAsync("/");
        }
    }
}
