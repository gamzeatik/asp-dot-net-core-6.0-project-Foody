using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Concrete;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework;

public class EfCategoryDal: GenericRepository<Category>, ICategoryDal
{
    public EfCategoryDal(FoodyContext context) : base(context)
    {
    }
}