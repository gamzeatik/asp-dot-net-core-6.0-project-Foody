using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;
    private readonly ICategoryDal _categoryDal;

    public ProductManager(IProductDal productDal, ICategoryDal categoryDal)
    {
        _productDal = productDal;
        _categoryDal = categoryDal;
    }

    public void TInsert(Product entity)
    {
        _productDal.Insert(entity);
    }

    public void TUpdate(Product entity)
    {
        _productDal.Update(entity);
    }

    public void TDelete(int id)
    {
        _productDal.Delete(id);
    }

    public List<Product> TGetAll()
    {
        return _productDal.GetAll();
    }

    public Product TGetById(int id)
    {
        return _productDal.GetById(id);
    }

    public List<Product> TProductListWithCategory()
    {
        return _productDal.ProductListWithCategory();
    }
}