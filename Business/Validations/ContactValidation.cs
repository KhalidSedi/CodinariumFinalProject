using Entities.Concrete.TableModels;
using FluentValidation;

namespace Business.Validations
{
    public class ContactValidation : AbstractValidator<Contact>
    {
        public ContactValidation()
        {
            
        }
    }
}
