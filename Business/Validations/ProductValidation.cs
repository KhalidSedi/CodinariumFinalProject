using Core.Messages;
using Entities.Concrete.TableModels;
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

            RuleFor(x => x.Description)
                   .MinimumLength(3)
                   .WithMessage(UIMessages.GetMinLengthMessage(3, "Açıqlama"))
                   .MaximumLength(150)
                   .WithMessage(UIMessages.GetMaxLengthMessage(150, "Açıqlama"))
                   .NotEmpty()
                   .WithMessage(UIMessages.GetRequiredMessage("Açıqlama"));

            RuleFor(x => x.Price)
                  .NotEmpty()
                  .WithMessage(UIMessages.GetRequiredMessage("Qiymət"));

            RuleFor(x => x.ImgUrl)
                  .MinimumLength(3)
                  .WithMessage(UIMessages.GetMinLengthMessage(3, "Şəkil"))
                  .MaximumLength(500)
                  .WithMessage(UIMessages.GetMaxLengthMessage(500, "Şəkil"))
                  .NotEmpty()
                  .WithMessage(UIMessages.GetRequiredMessage("Şəkil"));
        }
    }
}
