using Business.Abstract;
using Business.BaseMessages;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete.Dtos;
using Entities.Concrete.TableModels;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(CategoryCreateDto dto)
        {
            var model = CategoryCreateDto.ToCategory(dto);

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
