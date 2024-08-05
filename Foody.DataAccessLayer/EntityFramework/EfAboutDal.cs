using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Concrete;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework;

public class EfAboutDal : GenericRepository<About>, IAboutDal
{
    public EfAboutDal(FoodyContext context) : base(context)
    {
    }
}