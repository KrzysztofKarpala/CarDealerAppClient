using CarDealerAppClient.Models.User;

namespace CarDealerAppClient.ViewModels.User
{
    public interface IUserViewModel
    {
        public PasswordChangeModel PasswordChange { get; set; }
        public Validations FluentValidations { get; set; }
        Task SetNewPassword();
    }
}
