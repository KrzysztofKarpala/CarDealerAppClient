using FluentValidation;

namespace CarDealerAppClient.Models.User
{
    public class PasswordChangeModel
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string RepeatedNewPassword { get; set; }
    }
    public class PasswordChangeValidator : AbstractValidator<PasswordChangeModel>
    {
        public PasswordChangeValidator() 
        {
            RuleFor(x => x.OldPassword)
                .NotEmpty().WithMessage("Obecne hasło nie może być puste");
            RuleFor(x => x.NewPassword)
                .NotEmpty().WithMessage("Nowe hasło nie może być puste")
                .MaximumLength(20).WithMessage("Nowe hasło nie może mieć więcej niż 20 znaków");
            RuleFor(x => x.RepeatedNewPassword)
                .Equal(x => x.NewPassword).WithMessage("Powtórzone hasło jest różne")
                .NotEmpty().WithMessage(" ");
        }
    }
}
