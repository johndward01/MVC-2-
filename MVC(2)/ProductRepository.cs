using Dapper;
using MVC_2_.Models;
using System.Data;

namespace MVC_2_;

public class ProductRepository : IProductRepository
{
    private readonly IDbConnection _conn;

    public ProductRepository(IDbConnection conn)
    {
        _conn = conn;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
    }
}
