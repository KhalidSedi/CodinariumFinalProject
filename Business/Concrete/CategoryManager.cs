using Business.Abstract;
using Business.BaseMessages;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete.Dtos;
using Entities.Concrete.TableModels;
using FluentValidation;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        private readonly IValidator<Category> _validator;
        public CategoryManager(ICategoryDal categoryDal, IValidator<Category> validator)
        {
            _categoryDal = categoryDal;

            _validator = validator;
        }

        public IResult Add(CategoryCreateDto dto)
        {
            var model = CategoryCreateDto.ToCategory(dto);

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

            _categoryDal.Add(model);

            return new SuccessResult(UIMessages.ADDED_MESSAGE);
        }
        public IResult Update(CategoryUpdateDto dto)
        {
            var model = CategoryUpdateDto.ToCategory(dto);

            model.LastUpdatedDate = DateTime.Now;

            _categoryDal.Update(model);

            return new SuccessResult(UIMessages.UPDATED_MESSAGE);
        }
        public IResult Delete(int id)
        {
            var data = GetById(id).Data;

            data.Deleted = id;

            _categoryDal.Update(data);

            return new SuccessResult(UIMessages.DELETED_MESSAGE);
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccesDataResult<List<Category>>(_categoryDal.GetAll(x => x.Deleted == 0));
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccesDataResult<Category>(_categoryDal.GetById(id));
        }
    }
}
