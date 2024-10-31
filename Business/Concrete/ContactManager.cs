using Business.Abstract;
using Business.BaseMessages;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        ContactDal contactDal = new();

        IContactDal _contactDal = new ContactDal();

        public IResult Add(Contact entity)
        {
            contactDal.Add(entity); 

            return new SuccessResult(UIMessages.ADDED_MESSAGE);
        }
        public IResult Update(Contact entity)
        {
            entity.LastUpdatedDate = DateTime.Now;

            contactDal.Update(entity);

            return new SuccessResult(UIMessages.UPDATED_MESSAGE);
        }
        public IResult Delete(int id)
        {
            var data = GetById(id).Data;

            data.Deleted = id;

            contactDal.Update(data);

            return new SuccessResult(UIMessages.DELETED_MESSAGE);

        }
        public IDataResult<List<Contact>> GetAll(Expression<Func<Contact, bool>>? filter = null)
        {
            return new SuccesDataResult<List<Contact>>(contactDal.GetAll(x => x.Deleted == 0));   
        }

        public IDataResult<Contact> GetById(int id)
        {
           return new SuccesDataResult<Contact>(contactDal.GetById(id));
        }

        public IResult Find(int id)
        {
            var data = GetById(id).Data;

            data.IsRead = true;

            return new SuccessResult();
        }
    }
}
