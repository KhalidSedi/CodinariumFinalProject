using Core.DataAccess.Abstract;
using Entities.Concrete.Dtos;
using Entities.Concrete.TableModels;

namespace DataAccess.Abstract
{
    public interface IProductDal : IBaseRepository<Product>
    {
        List<ProductDto> GetProductWithCategories();
    }
}
