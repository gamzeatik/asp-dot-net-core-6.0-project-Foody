using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Concrete;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework;

public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
{
    public EfFeatureDal(FoodyContext context) : base(context)
    {
    }
}