using System;
using StoreModels;

namespace StoresUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Store bikeShop = new Store("Miami", "FL", "USA");
            bikeShop.Product = new Product
            {
                Item = "Disc Brakes",
                Price = 99
            };

            Console.WriteLine("Bike Shop");
            Console.WriteLine(bikeShop.Product);
        }
    }
}
