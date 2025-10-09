namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddProduct_ShouldAddProductToList()


        {
            // Arrange
            var service = new ProductService();
            var product = new Product
            {
                ProductName = "Testproduct",
                ArticleNumber = "123",
                IsService = false,
                Description = "Testdescription"
            };

            // Act
            bool result = service.AddProduct(product);
            var allProducts = service.GetAllProducts();

            // Assert
            Assert.True(result);                          
            Assert.Single(allProducts);                    
            Assert.Equal("Testproduct", allProducts.First().ProductName); 
        }
    }
        {

        }
    }
}
