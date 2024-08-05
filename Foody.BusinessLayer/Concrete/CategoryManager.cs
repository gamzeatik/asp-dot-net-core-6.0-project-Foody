using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void TInsert(Category entity)
    {
        _categoryDal.Insert(entity);
    }

    public void TUpdate(Category entity)
    {
        _categoryDal.Update(entity);
    }

    public void TDelete(int id)
    {
        _categoryDal.Delete(id);
    }

    public List<Category> TGetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category TGetById(int id)
    {
        return _categoryDal.GetById(id);
    }
}