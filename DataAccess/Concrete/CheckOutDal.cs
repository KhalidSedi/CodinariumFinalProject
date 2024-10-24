using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.TableModels;

namespace DataAccess.Concrete
{
    public class CheckOutDal : RepositoryBase<CheckOut, ApplicationDbContext>, ICheckOutDal
    {
    }
}
