using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.Abstract;

public interface IProductDal : IGenericDal<Product>
{
    List<Product> ProductListWithCategory();
}