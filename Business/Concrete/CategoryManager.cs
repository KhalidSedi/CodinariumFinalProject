using Business.Abstract;
using Business.BaseMessages;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.TableModels;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        CategoryDal categoryDal = new();
        public IResult Add(Category entity)
        {
            categoryDal.Add(entity);

            return new SuccessResult(UIMessages.ADDED_MESSAGE);
        }
        public IResult Update(Category entity)
        {
           entity.LastUpdatedDate = DateTime.Now;

            categoryDal.Update(entity);

            return new SuccessResult(UIMessages.UPDATED_MESSAGE);
        }
        public IResult Delete(int id)
        {
            var data = GetById(id).Data;

            data.Deleted = id;

            categoryDal.Update(data);

            return new SuccessResult(UIMessages.DELETED_MESSAGE);
        }

        public IDataResult<List<Category>> GetAll(Expression<Func<Category, bool>>? filter = null)
        {
            return new SuccesDataResult<List<Category>>(categoryDal.GetAll(x => x.Deleted == 0));
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccesDataResult<Category>(categoryDal.GetById(id));
        }
    }
}
