using CarDealerAppClient.Models.Login;
using CarDealerAppClient.Services.Navigation;
using CarDealerAppClient.ViewModels.Base;

namespace CarDealerAppClient.ViewModels.Login
{
    public class PasswordRecoveryViewModel : BaseViewModel, IPasswordRecoveryViewModel
    {
        public PasswordRecoveryViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public PasswordRecoveryModel PasswordRecovery { get; set; } = new PasswordRecoveryModel();
        public Validations FluentValidations { get; set; }

        public async Task SendPasswordRecovery()
        {
            if (await FluentValidations.ValidateAll())
            {
                throw new NotImplementedException();
            }
        }
    }
}
