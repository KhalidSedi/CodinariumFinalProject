using Business.Abstract;
using Business.BaseMessages;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete.TableModels;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User entity)
        {
           _userDal.Add(entity);

            return new SuccessResult(UIMessages.ADDED_MESSAGE);
        }
        public IResult Update(User entity)
        {
            entity.LastUpdatedDate = DateTime.Now;

            _userDal.Update(entity);

            return new SuccessResult(UIMessages.UPDATED_MESSAGE);
        }
        public IResult Delete(int id)
        {
            var data = GetById(id).Data;

            data.Deleted = id;

            _userDal.Update(data);

            return new SuccessResult(UIMessages.DELETED_MESSAGE);
        }
        public IDataResult<List<User>> GetAll(Expression<Func<User, bool>>? filter = null)
        {
            return new SuccesDataResult<List<User>>(_userDal.GetAll(x => x.Deleted == 0));
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccesDataResult<User>(_userDal.GetById(id));
        }
    }
}
