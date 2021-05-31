using System;

namespace Day2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product();
            Product1.ProductName = "Dress";
            Product1.ProductPrice = 400;
            Product1.ProductColour = "White";
            Product1.ProductSize = "Large";

            Product Product2 = new Product();
            Product2.ProductName = "T-Shirt";
            Product2.ProductPrice = 40;
            Product2.ProductColour = "Blue";
            Product2.ProductSize = "Medium";

            Product Product3 = new Product();
            Product3.ProductName = "Jacket";
            Product3.ProductPrice = 100;
            Product3.ProductColour = "Black";
            Product3.ProductSize = "Small";

            Product[] products = new Product[] { Product1,Product2, Product3 };
           
           
            foreach (var product in products)


                Console.WriteLine(product.ProductName + " " + product.ProductPrice + " " + product.ProductColour + " " + product.ProductSize);
        }
    }
}