using System;

namespace CAOopsExample
{
    class Product
    {
        int productId;string productName;double price;int qty;
        //Method
        public void GetProduct()
        {
            Console.WriteLine("Enter Product Details: ");
            productId = Convert.ToInt32(Console.ReadLine());
            productName = Console.ReadLine();
            price = Convert.ToDouble(Console.ReadLine());
            qty = Convert.ToInt32((Console.ReadLine()));
        }
        //Function
        public double GetTotalCost()
        {
            double total = price * qty;
            return total;
        }
        public void Display()
        {
            double total = GetTotalCost();
            Console.WriteLine($"Product ID: {productId}, Product Name: {productName} and Total value is: {total}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product pObj = new Product();
            pObj.GetProduct();
            pObj.Display();
            Console.Read();
        }
    }
}
