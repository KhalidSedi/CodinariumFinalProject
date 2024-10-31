using Business.Abstract;
using Business.BaseMessages;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete.Dtos;
using Entities.Concrete.TableModels;
using FluentValidation;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        private readonly IValidator<About> _validator;
        public AboutManager(IAboutDal aboutDal, IValidator<About> validator)
        {
            _aboutDal = aboutDal;
            _validator = validator;
        }
        public IResult Add(AboutCreateDto dto)
        {
            var model = AboutCreateDto.ToAbout(dto);

            var validator = _validator.Validate(model);

            string errorMessage = " ";

            foreach (var item in validator.Errors)
            {
                errorMessage = item.ErrorMessage;
            }

            if (!validator.IsValid)
            {
                return new ErrorResult(errorMessage);
            }

            _aboutDal.Add(model);

            return new SuccessResult(UIMessages.ADDED_MESSAGE);
        }
        public IResult Update(About entity)
        {
            entity.LastUpdatedDate = DateTime.Now;

            _aboutDal.Update(entity);

            return new SuccessResult(UIMessages.UPDATED_MESSAGE);
        }
        public IDataResult<List<About>> GetAll(Expression<Func<About, bool>>? filter = null)
        {
            return new SuccesDataResult<List<About>>(_aboutDal.GetAll());
        }
        public IDataResult<About> GetById(int id)
        {
            return new SuccesDataResult<About>(_aboutDal.GetById(id));
        }
    }
}
