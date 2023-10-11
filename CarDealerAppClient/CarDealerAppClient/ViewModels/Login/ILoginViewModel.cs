using CarDealerAppClient.Models.Login;

namespace CarDealerAppClient.ViewModels.Login
{
    public interface ILoginViewModel
    {
        public LoginModel Login { get; set; }
        Task NavigateToHome();
        Task NavigateToRegistration();
    }
}
