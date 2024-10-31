using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class AboutDal : RepositoryBase<About, ApplicationDbContext>, IAboutDal
    {
    }
}
