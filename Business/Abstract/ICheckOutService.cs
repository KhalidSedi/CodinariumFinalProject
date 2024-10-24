using Core.Results.Abstract;
using Entities.TableModels;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICheckOutService
    {
        IResult Add(Category entity);
        IResult Update(Category entity);
        IResult Delete(Category entity);
        IDataResult<List<Category>> GetAll(Expression<Func<Category, bool>>? filter = null);
        IDataResult<Category> GetById(int id);
    }
}
