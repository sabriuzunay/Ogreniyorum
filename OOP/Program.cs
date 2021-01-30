using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "elma";
            product1.UnitPrice = 15;
            product1.UnitInStock = 25;

            Product product2 = new Product { id = 2 , CategoryId = 4 , ProductName = "kasa", UnitPrice = 35 , UnitInStock = 55};
            Console.WriteLine(product1.ProductName);
            Console.WriteLine(product2.ProductName);
            int sayi = 100;
            ProductManager.BiseyYap(sayi);
            Console.WriteLine(sayi);
        }
    }
}
