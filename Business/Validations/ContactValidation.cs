using Core.Messages;
using Entities.Concrete.TableModels;
using FluentValidation;

namespace Business.Validations
{
    public class ContactValidation : AbstractValidator<Contact>
    {
        public ContactValidation()
        {
            RuleFor(x => x.Name)
                   .MinimumLength(3)
                   .WithMessage(UIMessages.GetMinLengthMessage(3, "İstifadəçi adı"))
                   .MaximumLength(100)
                   .WithMessage(UIMessages.GetMaxLengthMessage(100, "İstifadəçi adı"))
                   .NotEmpty()
                   .WithMessage(UIMessages.GetRequiredMessage("İstifadəçi adı"));

            RuleFor(x => x.Email)
                 .MinimumLength(5)
                 .WithMessage(UIMessages.GetMinLengthMessage(5, "Email"))
                 .MaximumLength(100)
                 .WithMessage(UIMessages.GetMaxLengthMessage(100, "Email"))
                 .NotEmpty()
                 .WithMessage(UIMessages.GetRequiredMessage("Email"));

            RuleFor(x => x.Subject)
                 .MinimumLength(5)
                 .WithMessage(UIMessages.GetMinLengthMessage(5, "Mövzu"))
                 .MaximumLength(100)
                 .WithMessage(UIMessages.GetMaxLengthMessage(100, "Mövzu"))
                 .NotEmpty()
                 .WithMessage(UIMessages.GetRequiredMessage("Mövzu"));

            RuleFor(x => x.Message)
                 .MinimumLength(5)
                 .WithMessage(UIMessages.GetMinLengthMessage(5, "Mesaj"))
                 .MaximumLength(5000)
                 .WithMessage(UIMessages.GetMaxLengthMessage(5000, "Mesaj"))
                 .NotEmpty()
                 .WithMessage(UIMessages.GetRequiredMessage("Mesaj"));
        }
    }
}
