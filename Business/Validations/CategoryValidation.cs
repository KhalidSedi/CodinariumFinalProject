using Core.Messages;
using Entities.TableModels;
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
