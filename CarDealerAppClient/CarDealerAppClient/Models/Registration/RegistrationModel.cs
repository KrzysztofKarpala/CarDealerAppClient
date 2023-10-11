using CarDealerAppClient.Models.Login;
using FluentValidation;

namespace CarDealerAppClient.Models.Registration
{
    public class RegistrationModel
    {
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string RepeatedPassword { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class RegistrationValidator : AbstractValidator<RegistrationModel>
    {
        public RegistrationValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Adres e-mail nie może być pusty")
                .EmailAddress().WithMessage("Nieprawidłowy adres e-mail");
            RuleFor(x => x.Login)
                .NotEmpty().WithMessage("Nazwa użytkownika nie może być pusta");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Hasło nie może być puste");
            RuleFor(x => x.RepeatedPassword)
                .Equal(x => x.Password).WithMessage("Powtórzone hasło jest różne")
                .NotEmpty().WithMessage(" ");
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Imię i nazwisko nie może być puste");
            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Numer telefonu nie może być pusty");
        }
    }
}
