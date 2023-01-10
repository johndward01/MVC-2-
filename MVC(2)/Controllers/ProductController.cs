using Microsoft.AspNetCore.Mvc;

namespace MVC_2_.Controllers;
public class ProductController : Controller
{
    private readonly IProductRepository _repo;

    public ProductController(IProductRepository repo)
    {
        _repo = repo;
    }

    public IActionResult Index()
    {
        var products = _repo.GetAllProducts();  
        return View(products);
    }
}
