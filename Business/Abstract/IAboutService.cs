using Core.Results.Abstract;
using Entities.Concrete.Dtos;
using Entities.Concrete.TableModels;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IAboutService
    {
        IResult Add(AboutCreateDto dto);
        IResult Update(About entity);
        IDataResult<List<About>> GetAll(Expression<Func<About, bool>>? filter = null);
        IDataResult<About> GetById(int id);
    }
}
