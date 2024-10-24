using Business.Abstract;
using Core.Results.Abstract;
using Entities.TableModels;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CheckOutManager : ICheckOutService
    {
        public IResult Add(Category entity)
        {
            throw new NotImplementedException();
        }
        public IResult Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> GetAll(Expression<Func<Category, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Category> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
