using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    interface IRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int productId);
        void AddProduct(Product product);
        void RemoveProduct(int productId);
        void UpdateProduct(Product product);

    }
    class ProductRepository : IRepository
    {
        List<Product> products = new List<Product>(); //datasource
        public void AddProduct(Product product)
        {
            //add product to the list
            products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            //return all products
            return products;
        }

        public Product GetProductById(int productId)
        {
            foreach (Product item in products)
            {
                if(item.Id == productId) return item;

            }
            return null; //when given product id not exisit
        }

        public void RemoveProduct(int productId)
        {
            Product product = null;
            foreach (Product item in products)
            {
                if (item.Id == productId)
                {
                    product = item;
                    break;
                }

            }
            if(product != null)
            products.Remove(product);
        }

        public void UpdateProduct(Product product)
        {
            for(int i = 0;i< products.Count; i++)
            {
                if(products[i].Id == product.Id)
                {
                    products[i].Price= product.Price; //update the price
                }
            }
        }
    }
    internal class Demo2
    {
        static void Main()
        {ProductRepository repository = new ProductRepository();
            do
            {
                Console.WriteLine("1.Add\n2.GetById\n3.GetAll\n4.Update\n5.Delete\n6.Exist");
                Console.WriteLine("Select Option");
                int op=int.Parse(Console.ReadLine());  
                switch(op)
                {
                    case 1: //Add Product
                        {
                            Product product=new Product();
                            product.Id = new Random().Next();
                            Console.WriteLine("Enter Name");
                            product.Name = Console.ReadLine();
                            Console.WriteLine("Enter Price");
                            product.Price = int.Parse(Console.ReadLine());
                            repository.AddProduct(product);
                        }
                        break;
                    case 2: //Search Product
                        {
                            Console.WriteLine("Enter Product Id");
                            int id=int.Parse(Console.ReadLine());
                            Product product=repository.GetProductById(id);
                            if (product != null)
                            {
                                Console.WriteLine(product.ToString());
                            }
                            else
                                Console.WriteLine("Invalid Id");
                        }
                        break;
                    case 3: //Get All Products
                        {
                            List<Product> products = repository.GetAllProducts();
                            if (products.Count > 0)
                            {
                                foreach (var item in products)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            else
                                Console.WriteLine("List is Empty");
                        }
                        break;
                    case 5: //delete product
                        {
                            Console.WriteLine("Enter Product Id");
                            int id = int.Parse(Console.ReadLine());
                            repository.RemoveProduct(id);
                        }
                        break;
                    case 4: //update product
                        {
                            Product product = new Product();
                            product.Id = int.Parse(Console.ReadLine()) ;
                            Console.WriteLine("Enter Price");
                            product.Price = int.Parse(Console.ReadLine());
                            repository.UpdateProduct(product);
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }while(true);
        }
    }
}
