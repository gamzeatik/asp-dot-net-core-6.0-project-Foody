using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Abstract;

public interface IProductService : IGenericService<Product>
{
    List<Product> TProductListWithCategory();
}