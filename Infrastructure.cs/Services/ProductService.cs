using Infrastructure.cs.Interfaces;
using Infrastructure.cs.Models;

namespace Infrastructure.cs.Services;


public class ProductService(IFileService fileService) : IProductService
{
    private List<Product> _productList = [];

    public bool AddToProductList(ProductCreateRequest product)
    {
        product.Id = Guid.NewGuid().ToString();
        product.ProductName = product.ProductName.Trim();
        _productList.Add(product);
        return true;
    }

    public bool CreateProduct(ProductCreateRequest product)
    {
        product.Id = Guid.NewGuid().ToString();
        product.ProductName = product.ProductName.Trim();
        _productList.Add(product);
    }

    public bool DeleteProduct(string id)
    {
        var existing_product = GetProductById(id);

        if (existing_user is not null)
        {
            _productList.Remove(existing_product);

            var result = _filePath.Write(_productList);
            return result;
        }

        return false;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _productList;
    }

    public Product GetProductByArticleNumber(string articleNumber)
    {
        var product = _productList.FirstOrDefault(x => x.ArticleNumber == articleNumber);
        return product;
    }

    public Product GetProductByProductName(string productName)
    {
        var product = _productList.FirstOrDefault(x => x.ProductName == productName);
        return product;
    }

    public Product GetProductsbyId(string id)
    {
        var product = _productList.FirstOrDefault(x => product.Id == id);
        return product;
    }

    public bool UpdateProduct(string id, ProductUpdateRequest product)
    {
        var existing_prodyct = GetProductById(product.Id);

        if (existing_product is not null)
        {
            existing_product.FirstName = product.FirstName;
            existing_product.LastName = product.LastName;

            if (existing_product.Email != product.Email)
            {
                var existing_email = _productList.Any( => product.Email == product.Email);
                if (existing_product)
                    return false;

                existing_product.Email = user.Email;
            }

            var result = _filePath.Write(_productList);
            return result;
        }

}