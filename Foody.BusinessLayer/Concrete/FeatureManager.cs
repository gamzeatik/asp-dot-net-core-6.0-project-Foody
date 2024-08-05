using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete;

public class FeatureManager : IFeatureService
{
    private readonly IFeatureDal _featureDal;

    public FeatureManager(IFeatureDal featureDal)
    {
        _featureDal = featureDal;
    }

    public void TInsert(Feature entity)
    {
        _featureDal.Insert(entity);
    }

    public void TUpdate(Feature entity)
    {
        _featureDal.Update(entity);
    }

    public void TDelete(int id)
    {
        _featureDal.Delete(id);
    }

    public List<Feature> TGetAll()
    {
        return _featureDal.GetAll();
    }

    public Feature TGetById(int id)
    {
        return _featureDal.GetById(id);
    }
}