using Core.Messages;
using Entities.Concrete.TableModels;
using FluentValidation;

namespace Business.Validations
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(x => x.Name)
                   .MinimumLength(3)
                   .WithMessage(UIMessages.GetMinLengthMessage(3, "İstifadəçi adı"))
                   .MaximumLength(50)
                   .WithMessage(UIMessages.GetMaxLengthMessage(50, "İstifadəçi adı"))
                   .NotEmpty()
                   .WithMessage(UIMessages.GetRequiredMessage("İstifadəçi adı"));

            RuleFor(x => x.Email)
                  .MinimumLength(5)
                  .WithMessage(UIMessages.GetMinLengthMessage(5, "Email"))
                  .MaximumLength(100)
                  .WithMessage(UIMessages.GetMaxLengthMessage(100, "Email"))
                  .NotEmpty()
                  .WithMessage(UIMessages.GetRequiredMessage("Email"));

            RuleFor(x => x.Password)
                  .MinimumLength(5)
                  .WithMessage(UIMessages.GetMinLengthMessage(5, "Parol"))
                  .MaximumLength(100)
                  .WithMessage(UIMessages.GetMaxLengthMessage(100, "Parol"))
                  .NotEmpty()
                  .WithMessage(UIMessages.GetRequiredMessage("Parol"));

            RuleFor(x => x.Phone)
                 .MinimumLength(10)
                 .WithMessage(UIMessages.GetMinLengthMessage(10, "Nömrə"))
                 .MaximumLength(20)
                 .WithMessage(UIMessages.GetMaxLengthMessage(20, "Nömrə"))
                 .NotEmpty()
                 .WithMessage(UIMessages.GetRequiredMessage("Nömrə"));

            RuleFor(x => x.Address)
                 .MinimumLength(5)
                 .WithMessage(UIMessages.GetMinLengthMessage(5, "Adres"))
                 .MaximumLength(150)
                 .WithMessage(UIMessages.GetMaxLengthMessage(150, "Adres"))
                 .NotEmpty()
                 .WithMessage(UIMessages.GetRequiredMessage("Adres"));
        }
    }
}
