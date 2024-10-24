using Business.Abstract;
using Core.Results.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.TableModels;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        ProductDal productDal = new();

        public IResult Add(Product entity)
        {
            throw new NotImplementedException();
        }
        public IResult Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetAll(Expression<Func<Contact, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

