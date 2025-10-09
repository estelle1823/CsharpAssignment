using Infrastructure.cs.Interfaces;
using Infrastructure.cs.Models;
using Infrastructure.cs.Services;
using System.Reflection.Metadata;


string filePath = @"c:\data\products.json";
var jsonFileService = new JsonFileService(filePath;


IProductService productService = new ProductService();

var product = new ProductCreateRequest();
productService.CreateProduct(product);

var productName = new Product();
productService.GetProductByProductName(ProductName);


var product = new ProductUpdateRequest();
productService.UpdateProduct(product);



foreach (var product in _productList.GetAllProducts())
{
    Console.WriteLine($"{product.Id} | {product.ProductName} - {product.UnitPrice} kr");
}



var productService = new ProductService();
IFileService fileService = new JsonFileService(@"c:\data\products.json");

// Läs från fil
string jsonContent = fileService.GetJsonContentFromFile();

if (!string.IsNullOrWhiteSpace(innehåll))
{
    var products = JsonSerializer.Deserialize<List<Product>>(innehåll);
    if (products != null)
    {
        foreach (var product in products)
        {
            productService.AddProduct(product);
        }
    }
}


Console.WriteLine("Add a new product:");

Console.Write("Name: ");
string namn = Console.ReadLine();

Console.Write("Price: ");
string priceText = Console.ReadLine();
decimal Unitprice = Convert.ToDecimal(priceText); 

productService.AddProduct(new Product
{
    Name = name,
    Price = price
});


string newJsonContent = JsonSerializer.Serialize(productService.GetAllProducts(), new JsonSerializerOptions
{
    WriteIndented = true
});

bool save = fileService.SaveJsonContentToFile(newJsonContent);

if (saved)
    Console.WriteLine("Product saved to file.");
else
    Console.WriteLine("Something went wrong.");
