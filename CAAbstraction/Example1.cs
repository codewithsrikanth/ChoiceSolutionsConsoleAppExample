using System;

namespace CAAbstraction
{
    interface IProduct
    {
        void GetData();
        void Display();
    }
    class Product : IProduct
    {
        public void Display()
        {
            Console.WriteLine("This is Display");
        }

        public void GetData()
        {
            Console.WriteLine("This is GetData");
        }
    }
    class Example1
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.GetData();
            p1.Display();
            Console.Read();
        }
    }
}
