using Infrastructure.cs.Interfaces;
using Infrastructure.cs.Models;

namespace Infrastructure.cs.Services;


public class ProductService : IProductService
{
    public bool CreateProduct(ProductCreateRequest product)
    {
        throw new NotImplementedException();
    }

    public bool DeleteProduct(string id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public Product GetProductByArticleNumber(string articleNumber)
    {
        throw new NotImplementedException();
    }

    public Product GetProductByProductName(string productName)
    {
        throw new NotImplementedException();
    }

    public Product GetProductsbyId(string id)
    {
        throw new NotImplementedException();
    }

    public bool UpdateProduct(string id, ProductUpdateRequest product)
    {
        throw new NotImplementedException();
    }
}