using Core.Results.Abstract;
using Entities.Concrete.TableModels;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User entity);
        IResult Update(User entity);
        IResult Delete(int id);
        IDataResult<List<User>> GetAll(Expression<Func<User, bool>>? filter = null);
        IDataResult<User> GetById(int id);
    }
}
