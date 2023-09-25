using CarDealerAppClient.Models.User;
using CarDealerAppClient.Services.Navigation;
using CarDealerAppClient.ViewModels.Base;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace CarDealerAppClient.ViewModels.User
{
    public class UserViewModel : BaseViewModel, IUserViewModel
    {
        public UserViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string RepeatedNewPassword { get; set; }
        public Validations FluentValidations { get; set; }
        public PasswordChangeModel PasswordChange { get; set; } = new PasswordChangeModel();

        public async Task SetNewPassword()
        {
            if(await FluentValidations.ValidateAll())
            {
                throw new NotImplementedException();
            }
        }
    }
}
