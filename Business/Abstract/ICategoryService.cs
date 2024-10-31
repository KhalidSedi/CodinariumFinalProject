using Core.Results.Abstract;
using Entities.Concrete.Dtos;
using Entities.Concrete.TableModels;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IResult Add(CategoryCreateDto dto);
        IResult Update(CategoryUpdateDto dto);
        IResult Delete(int id);
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int id);
    }
}
