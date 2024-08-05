using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Concrete;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    public EfProductDal(FoodyContext context) : base(context)
    {
    }
}