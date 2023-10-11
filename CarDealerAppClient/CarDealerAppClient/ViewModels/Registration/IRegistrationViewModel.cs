
using CarDealerAppClient.Models.Registration;

namespace CarDealerAppClient.ViewModels.Registration
{
    public interface IRegistrationViewModel
    {
        public RegistrationModel Registration { get; set; }
        public Validations FluentValidations { get; set; }
        Task NewUserRegistration();
    }
}
