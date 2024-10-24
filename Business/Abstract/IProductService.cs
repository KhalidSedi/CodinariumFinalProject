using Core.Results.Abstract;
using Entities.TableModels;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product entity);
        IResult Update(Product entity);
        IResult Delete(Product entity);
        IDataResult<List<Product>> GetAll(Expression<Func<Contact, bool>>? filter = null);
        IDataResult<Product> GetById(int id);
    }
}
