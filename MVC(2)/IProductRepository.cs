using MVC_2_.Models;

namespace MVC_2_;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
}
