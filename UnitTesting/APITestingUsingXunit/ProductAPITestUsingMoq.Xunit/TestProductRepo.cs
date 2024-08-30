using System;
using Xunit;
using Moq;
using ProductAPI.Repositories;
using System.Collections.Generic;
using ProductAPI.Models;
using System.Linq;
using ProductAPI.Services;

namespace ProductAPITestUsingMoq.Xunit
{
    public class TestProductRepo
    {
        private readonly IProductRepo _repo;

        public TestProductRepo()
        {
            var mockRepo = new Mock<IProductRepo>();
            IList<Products> products = new List<Products>() {
            new Products(){Pid=1,Pname="ABC",Price=100,Stock=100},
            new Products(){Pid=2,Pname="XYZ",Price=100,Stock=100},
            new Products(){Pid=3,Pname="AAA",Price=100,Stock=100},
            new Products(){Pid=4,Pname="BBB",Price=100,Stock=100},
            new Products(){Pid=5,Pname="CCC",Price=100,Stock=100},
            };
            mockRepo.Setup(item => item.GetProducts()).Returns(products.ToList());
            mockRepo.Setup(repo => repo.GetProduct(It.IsAny<int>())).Returns((int i) => products.SingleOrDefault(x => x.Pid == i));
            mockRepo.Setup(repo => repo.AddProduct(It.IsAny<Products>())).Callback((Products item) =>
              {
                item = new Products() { Pid = 6, Pname = "DDD", Price = 100, Stock = 100 };
                  products.Add(item);
              }).Verifiable();
            mockRepo.Setup(repo => repo.DeleteProduct(It.IsAny<Products>())).Callback((Products item) =>
            {
                item = new Products() { Pid = 6, Pname = "DDD", Price = 100, Stock = 100 };
                products.Remove(item);
            }).Verifiable();
            mockRepo.SetupAllProperties();
            _repo = mockRepo.Object;
        }
        [Fact]
        public void TestGetProducts()
        {
            //Arrange
            int expected = 5;
            //Act
            var productlist = _repo.GetProducts();
            //Assert
            Assert.Equal(expected, productlist.Count);
        }
        [Fact]
        public void TestGetProduct()
        {
            //Arrange
            int expected = 1;
            //Act
            var product = _repo.GetProduct(1);
            Assert.Equal(expected, product.Pid);
        }
        [Fact]
        public void TestAddProduct()
        {
            var productdetails = new Products() { Pid = 6, Pname = "DDD", Price = 100, Stock = 100 };

             _repo.AddProduct(productdetails);

            Assert.Equal(1, 1);
        }
        [Fact]
        public void TestDeleteProduct()
        {
            var productdetails = new Products() { Pid = 5, Pname = "CCC", Price = 100, Stock = 100 };

            _repo.DeleteProduct(productdetails);

            Assert.Equal(1, 1);
        }
    }
}
