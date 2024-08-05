using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Concrete;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework;

public class EfSliderDal: GenericRepository<Slider>, ISliderDal
{
    public EfSliderDal(FoodyContext context) : base(context)
    {
    }
}