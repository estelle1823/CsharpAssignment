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
productService.GetProductByProductName(productName);


var product = new ProductUpdateRequest();
productService.UpdateProduct(product);



