using Foody.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers;

public class ProductsController : Controller
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    public IActionResult ProductList()
    {
        var values = _productService.TGetAll();
        return View(values);
    }

    public IActionResult ProductListWithCategory()
    {
        var values = _productService.TProductListWithCategory();
        return View(values);
    }

    [HttpGet]
    public IActionResult CreateProduct()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        _productService.TInsert(product);
        return RedirectToAction("ProductListWithCategory");
    }

    [HttpDelete]
    public IActionResult DeleteProduct(int id)
    {
        _productService.TDelete(id);
        return RedirectToAction("ProductListWithCategory");
    }
}