using CarDealerAppClient.Models.Login;

namespace CarDealerAppClient.ViewModels.Login
{
    public interface IPasswordRecoveryViewModel
    {
        public PasswordRecoveryModel PasswordRecovery { get; set; }
        public Validations FluentValidations { get; set; }
        Task SendPasswordRecovery();
    }
}
