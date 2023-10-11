using CarDealerAppClient.Models.Registration;
using CarDealerAppClient.Services.Navigation;
using CarDealerAppClient.ViewModels.Base;

namespace CarDealerAppClient.ViewModels.Registration
{
    public class RegistrationViewModel : BaseViewModel, IRegistrationViewModel
    {
        public RegistrationViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public RegistrationModel Registration { get; set; } = new RegistrationModel();
        public Validations FluentValidations { get; set; }


        public async Task NewUserRegistration()
        {
            if (await FluentValidations.ValidateAll())
            {
                throw new NotImplementedException();
            }
        }
    }
}
