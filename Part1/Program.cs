using System;
using Order;

namespace Customer
{
    class Customer
    {
        public string strName;

        public void getName()
        {
            Console.WriteLine("Enter your name: ");
            strName = Console.ReadLine();
        }
    }
}

namespace Order
{
    class GroceryItems
    {
        public void Ord_grocery()
        {
            Customer.Customer objCust1 = new Customer.Customer();
            objCust1.getName();
            Console.WriteLine("Hello {0}", objCust1.strName);
            Console.WriteLine("You have ordered grocery items");
        }
    }

    class BakeryProducts
    {
        public void Ord_bakery()
        {
            Customer.Customer objCust2 = new Customer.Customer();
            objCust2.getName();
            Console.WriteLine("Hello {0}", objCust2.strName);
            Console.WriteLine("You have ordered bakery items");
        }
    }
}

namespace Part3.Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string choice;
            Console.WriteLine(@"What would you like to order? 1-Grocery Items, 2- Bakery Items");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                GroceryItems objGrocery = new GroceryItems();
                objGrocery.Ord_grocery();
            }
            else
            {
                if (choice == "2")
                {
                    BakeryProducts objBakery = new BakeryProducts();
                    objBakery.Ord_bakery();
                }
                else
                {
                    Console.WriteLine("Enter either 1 or 2");
                }
            }
        }
    }
}