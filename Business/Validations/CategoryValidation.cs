using Core.Messages;
using Entities.Concrete.TableModels;
using FluentValidation;

namespace Business.Validations
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation() 
        {
           
        }
    }
}
