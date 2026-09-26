using ProductsApi.Models;

namespace ProductsApi.Services;

public class ProductService : IProductService
{
    private readonly List<Product> _products = new()
    {
        new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 350000
        },
        new Product
        {
            Id = 2,
            Name = "Mouse",
            Price = 12000
        },
        new Product
        {
            Id = 3,
            Name = "Keyboard",
            Price = 25000
        }
    };

    public IEnumerable<Product> GetAll()
    {
        return _products;
    }

    public Product? GetById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }
}
