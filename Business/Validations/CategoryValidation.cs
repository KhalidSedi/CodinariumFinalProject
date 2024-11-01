using Core.Messages;
using Entities.Concrete.TableModels;
using FluentValidation;

namespace Business.Validations
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation() 
        {
            RuleFor(x => x.Name)
                   .MinimumLength(3)
                   .WithMessage(UIMessages.GetMinLengthMessage(3, "Kateqoriya adı"))
                   .MaximumLength(50)
                   .WithMessage(UIMessages.GetMaxLengthMessage(50, "Kateqoriya adı"))
                   .NotEmpty()
                   .WithMessage(UIMessages.GetRequiredMessage("Kateqoriya adı"));

            RuleFor(x => x.IconName)
                 .MinimumLength(5)
                 .WithMessage(UIMessages.GetMinLengthMessage(5, "Ikon adı"))
                 .MaximumLength(100)
                 .WithMessage(UIMessages.GetMaxLengthMessage(100, "Ikon adı"))
                 .NotEmpty()
                 .WithMessage(UIMessages.GetRequiredMessage("Ikon adı"));
        }
    }
}
