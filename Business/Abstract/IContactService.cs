﻿using Core.Results.Abstract;
using Entities.Concrete.TableModels;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IContactService
    {
        IResult Add(Contact entity);
        IResult Update(Contact entity);
        IResult Delete(int id);
        IResult Find(int id);
        IDataResult<List<Contact>> GetAll(Expression<Func<Contact, bool>>? filter = null);
        IDataResult<Contact> GetById(int id);
    }
}
