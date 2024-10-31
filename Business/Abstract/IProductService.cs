using Core.Results.Abstract;
using Entities.Concrete.Dtos;
using Entities.Concrete.TableModels;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product entity);
        IResult Update(Product entity);
        IResult Delete(int id);
        IDataResult<List<ProductDto>> GetProductWithCategoryId();
        IDataResult<Product> GetById(int id);
    }
}
