using Infrastructure.cs.Models;

namespace Infrastructure.cs.Interfaces;

public interface IProductService
{
    bool CreateProduct(ProductCreateRequest product);

    IEnumerable<Product> GetAllProducts();

    Product GetProductsbyId(string id);
    Product GetProductByArticleNumber(string articleNumber);
    Product GetProductByProductName(string productName);
     
    bool UpdateProduct(string id, ProductUpdateRequest product);

    bool DeleteProduct(string id);
}
