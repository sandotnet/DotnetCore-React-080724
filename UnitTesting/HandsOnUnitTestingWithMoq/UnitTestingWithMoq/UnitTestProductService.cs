using Moq;
using ProductAPI.Controllers;
using ProductAPI.Entities;
using ProductAPI.Services;

namespace UnitTestingWithMoq
{
    public class UnitTestProductService
    {
        private readonly Mock<IProductService> productService;
        public UnitTestProductService()
        {
            productService = new Mock<IProductService>();
        }
        [Fact]
        public void Test_GetProductList()
        {
            var productList = GetProductsData();
            productService.Setup(x => x.GetProductList()).Returns(productList);
            var result = productService.Object; //moq service
            var productResult = result.GetProductList().ToList();
            Assert.NotNull(productResult);
            Assert.Equal(productList.Count, productResult.Count);
            Assert.NotEqual(0, productResult.Count);
        }
        [Fact]
        public void Test_GetProductByID()
        {
            //arrange
            var productList = GetProductsData();
            productService.Setup(x => x.GetProductById(2))
                .Returns(productList[1]);
            var result = productService.Object; //moq service
            //act
            var productResult = result.GetProductById(3);
            //assert
            Assert.True(productList[1].ProductId == productResult.ProductId);
        }
        [Fact]
        public void Test_DeleteProduct()
        {
            //arrange
            var productList = GetProductsData();
            productService.Setup(x => x.DeleteProduct(2))
                .Returns(true);
            var result = productService.Object; //moq service
            //act
            var productResult = result.DeleteProduct(2);
            //assert
            Assert.True(productResult);
           
        }
        [Fact]
        public void Test_AddProduct()
        {
            //arrange
            var product = new Product
            {
                ProductId = 4,
                ProductName = "IPhone 14 Pro",
                ProductDescription = "IPhone 14 Pro",
                ProductPrice = 155000,
                ProductStock = 10
            };
            var productList = GetProductsData();
            productList.Add(product);
            productService.Setup(x => x.AddProduct(product))
                .Returns(productList[3]);
            var result = productService.Object; //moq service
            //act
            var productResult = result.AddProduct(product);
            //assert
            Assert.NotNull(productResult);
            Assert.Equal(productList[3].ProductId, productResult.ProductId);
            Assert.True(productList[3].ProductId == productResult.ProductId);
        }
        [Fact]
        public void Test_EditProduct()
        {
            //arrange
            var productList = GetProductsData();
            productService.Setup(x => x.UpdateProduct(productList[2]))
                .Returns(productList[2]);
            var result = productService.Object; //moq service
            //act
            var productResult = result.UpdateProduct(productList[2]);
            //assert
            Assert.NotNull(productResult);
            Assert.Equal(productList[2].ProductId, productResult.ProductId);
            Assert.True(productList[2].ProductId == productResult.ProductId);
        }
        private List<Product> GetProductsData()
        {
            List<Product> productsData = new List<Product>
        {
            new Product
            {
                ProductId = 1,
                ProductName = "IPhone",
                ProductDescription = "IPhone 12",
                ProductPrice = 55000,
                ProductStock = 10
            },
             new Product
            {
                ProductId = 2,
                ProductName = "Laptop",
                ProductDescription = "HP Pavilion",
                ProductPrice = 100000,
                ProductStock = 20
            },
             new Product
            {
                ProductId = 3,
                ProductName = "TV",
                ProductDescription = "Samsung Smart TV",
                ProductPrice = 35000,
                ProductStock = 30
            },
        };
            return productsData;
        }
    }
}