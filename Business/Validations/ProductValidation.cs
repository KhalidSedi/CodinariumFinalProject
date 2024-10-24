using Core.Messages;
using Entities.TableModels;
using FluentValidation;

namespace Business.Validations
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(x => x.Name)
                   .MinimumLength(3)
                   .WithMessage(UIMessages.GetMinLengthMessage(3, "Məhsul Adı"))
                   .MaximumLength(50)
                   .WithMessage(UIMessages.GetMaxLengthMessage(50, "Məhsul adı"))
                   .NotEmpty()
                   .WithMessage(UIMessages.GetRequiredMessage("Məhsul Adı"));

        }

    }
}
