using Core.Messages;
using Entities.Concrete.TableModels;
using FluentValidation;

namespace Business.Validations
{
    public class AboutValidation : AbstractValidator<About>
    {
        public AboutValidation()
        {
            RuleFor(x => x.Description)
                   .MinimumLength(5)
                   .WithMessage(UIMessages.GetMinLengthMessage(5, "Açıqlama"))
                   .MaximumLength(5000)
                   .WithMessage(UIMessages.GetMaxLengthMessage(5000, "Açıqlama"))
                   .NotEmpty()
                   .WithMessage(UIMessages.GetRequiredMessage("Açıqlama"));
        }
    }
}
