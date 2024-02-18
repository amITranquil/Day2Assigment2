using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="PC"},
                new Category{CategoryId=2,CategoryName="Phone"}
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1,ProductName="Casper",ProductDescription="16GB Ram",UnitPrice=1200,UnitsInStock=5},
                new Product{ProductId=2,CategoryId=2,ProductName="Poco",ProductDescription="8GB Ram",UnitPrice=1400,UnitsInStock=15},
                new Product{ProductId=3,CategoryId=1,ProductName="HP",ProductDescription="24GB Ram",UnitPrice=1600,UnitsInStock=25},
                new Product{ProductId=4,CategoryId=1,ProductName="Dell",ProductDescription="32GB Ram",UnitPrice=1800,UnitsInStock=35},
                new Product{ProductId=5,CategoryId=2,ProductName="Apple",ProductDescription="64GB Ram",UnitPrice=2000,UnitsInStock=45},
            };

            Console.WriteLine("Without Linq---------------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 1200 && product.UnitsInStock > 16)
                {
                    Console.WriteLine(product.ProductName);
                }

            }
            Console.WriteLine("Linq---------------");

            var result = products.Where(p => p.UnitPrice > 1200 && p.UnitsInStock > 16);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            GetProducts(products);

            Console.ReadLine();
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 1200 && product.UnitsInStock > 16)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 1200 && p.UnitsInStock > 16).ToList();
        }

    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
