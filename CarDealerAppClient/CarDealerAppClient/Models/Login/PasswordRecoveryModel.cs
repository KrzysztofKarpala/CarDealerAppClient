using CarDealerAppClient.Models.User;
using FluentValidation;

namespace CarDealerAppClient.Models.Login
{
    public class PasswordRecoveryModel
    {
        public string Email { get; set; }
    }

    public class PasswordRecoveryValidator : AbstractValidator<PasswordRecoveryModel>
    {
        public PasswordRecoveryValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Adres e-mail nie może być pusty")
                .EmailAddress().WithMessage("Nieprawidłowy adres e-mail");
        }
    }
}
