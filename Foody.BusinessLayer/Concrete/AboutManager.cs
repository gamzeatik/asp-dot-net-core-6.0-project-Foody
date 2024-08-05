using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete;

public class AboutManager : IAboutService
{
    private readonly IAboutDal _aboutDal;

    public AboutManager(IAboutDal aboutDal)
    {
        _aboutDal = aboutDal;
    }

    public void TInsert(About entity)
    {
        _aboutDal.Insert(entity);
    }

    public void TUpdate(About entity)
    {
        _aboutDal.Update(entity);
    }

    public void TDelete(int id)
    {
        _aboutDal.Delete(id);
    }

    public List<About> TGetAll()
    {
        return _aboutDal.GetAll();
    }

    public About TGetById(int id)
    {
        return _aboutDal.GetById(id);
    }
}