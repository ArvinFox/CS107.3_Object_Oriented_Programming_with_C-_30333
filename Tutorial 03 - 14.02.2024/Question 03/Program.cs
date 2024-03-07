using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question_03
{
    internal class Program
    {

        public class Product
        {
            private int productId;
            private string productName;
            private double price;
            private int quantityInStock;
            private int newstock;

            public Product(int productId, string productName, double price, int quantityInStock)
            {
                this.productId = productId;
                this.productName = productName;
                this.price = price;
                this.quantityInStock = quantityInStock;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Product ID: {productId}");
                Console.WriteLine($"Product Name : {productName}");
                Console.WriteLine($"Product Price : {price}");
                Console.WriteLine($"Product Stock : {quantityInStock}");
            }
            public void AddProduct()
            {
                Console.WriteLine("\nHow many item(s) do you need to add?");
                newstock = Convert.ToInt32(Console.ReadLine());
                quantityInStock += newstock;
                Console.WriteLine($"\nYou added items to the stock.\nNew stock: {quantityInStock}");
            }
            public void BuyProduct()
            {
                Console.WriteLine("\nHow many item(s) do you need to buy?");
                newstock = Convert.ToInt32(Console.ReadLine());
                while(quantityInStock<newstock)
                {
                    Console.WriteLine($"The amount you entered is not available in our stock.\nProduct stock: {quantityInStock}");
                    Console.WriteLine("Enter a different value!");
                    newstock = Convert.ToInt32(Console.ReadLine());
                }
                quantityInStock -= newstock;
                Console.WriteLine($"\nYou bought: {newstock} items.\nNew stock: {quantityInStock}");
            }
        }
        static void Main(string[] args)
        {
            Product newproduct = new Product(101, "Laptop", 800, 10);
            newproduct.DisplayInfo();

            newproduct.AddProduct();
            newproduct.BuyProduct();

            Console.ReadLine();
        }
    }
}