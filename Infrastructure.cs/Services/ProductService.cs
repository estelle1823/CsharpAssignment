using Infrastructure.cs.Interfaces;
using Infrastructure.cs.Models;

namespace Infrastructure.cs.Services;


public class ProductService(IFileService fileService) : IProductService
{
    private List<Product> _productList = [];

    public bool AddToProductList(ProductCreateRequest product)
    {
        if (newProduct == null)
            return false;

        if (string.IsNullOrWhiteSpace(newProduct.Name))
            return false;

        Product product = new()
        {
            Id = Guid.NewGuid().ToString(),
            ArticleNumber = newProduct.ArticleNumber,
            Name = newProduct.Name,
            Description = newProduct.Description
        };

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
        var product = _productList.FirstOrDefault(x => x.Name == name);
        return product;
    }

    public Product GetProductsbyId(string id)
    {
        var product = _productList.FirstOrDefault(x => x.Id == id);
        return product;
    }

    public bool UpdateProduct(string id, ProductUpdateRequest product)
    {
        var existing_prodyct = GetProductById(user.Id);

        if (existing_product is not null)
        {
            existing_product.FirstName = user.FirstName;
            existing_product.LastName = user.LastName;

            if (existing_product.Email != user.Email)
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