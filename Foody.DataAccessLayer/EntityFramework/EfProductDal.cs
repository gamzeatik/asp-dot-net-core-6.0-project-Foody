using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Concrete;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Foody.DataAccessLayer.EntityFramework;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    private readonly FoodyContext _context;

    public EfProductDal(FoodyContext context) : base(context)
    {
        _context = context;
    }

    public List<Product> ProductListWithCategory()
    {
        var values = _context.Products.Include(p => p.Category).ToList();
        return values;
    }
}