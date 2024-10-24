using Business.Abstract;
using Core.Results.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.TableModels;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        ContactDal contactDal = new();

        IContactDal _contactDal = new ContactDal();

        public IResult Add(Contact entity)
        {
            throw new NotImplementedException();
        }
        public IResult Update(Contact entity)
        {
            throw new NotImplementedException();
        }
        public IResult Delete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Contact>> GetAll(Expression<Func<Contact, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Contact> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
