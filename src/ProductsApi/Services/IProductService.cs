using ProductsApi.Models;

namespace ProductsApi.Services;

public interface IProductService
{
    IEnumerable<Product> GetAll();
    Product? GetById(int id);
}
