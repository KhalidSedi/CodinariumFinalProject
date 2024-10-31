using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete.Dtos;
using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class ProductDal : RepositoryBase<Product, ApplicationDbContext>, IProductDal
    {
        private readonly ApplicationDbContext _context;
        public ProductDal(ApplicationDbContext context) 
        {
            _context = context;
        }
        public List<ProductDto> GetProductWithCategories()
        {
            //var data = context.Products
            //           .Where(x => x.Deleted == 0)
            //           .Include(x => x.Category).ToList();

            //return data;

            var result = from product in _context.Products
                         where product.Deleted == 0
                         join productC in _context.Categories
                         on product.CategoryId equals productC.Id
                         where productC.Deleted == 0
                         select new ProductDto
                         {
                             Id = product.Id,
                             Name = product.Name,
                             Description = product.Description,
                             IsHomePage = product.IsHomePage,
                             ImgUrl = product.ImgUrl,
                             CategoryId = product.CategoryId,
                             Price = product.Price,
                             CategoryName = productC.Name
                         };

            return result.ToList();
        }
    }
}
