using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_04
{
    internal class Program
    {
        class Product
        {
            public string ProductName;
            public double Price;

            public Product(string x, double y)
            {
                ProductName = x;
                Price = y;
            }
        }
        static void DisplayProducts(Product product)
        {
            Console.WriteLine("Product Name: " + product.ProductName + "\nPrice: " + product.Price + "\n");
        }
        static void Main(string[] args)
        {
            Product newProduct = new Product("Book", 350);
            Product newProduct1 = new Product("Pencil", 40);
            Product newProduct2 = new Product("Eraser", 25);

            DisplayProducts(newProduct);
            DisplayProducts(newProduct1);
            DisplayProducts(newProduct2);

            Console.ReadLine();
        }   
    }
}
