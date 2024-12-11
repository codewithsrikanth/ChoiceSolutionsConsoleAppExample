using System;
using System.Runtime.CompilerServices;

namespace CAOverloading
{
    class Program
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("Addition is: " + (x + y));
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("Addition is: " + (a + b + c));
        }
        public void Add(string x, int y)
        {
            Console.WriteLine("Addition is: " + (x + y));
        }
        public void Add(int y, string x)
        {
            
            Console.WriteLine("Addition is: " + (x + y));           
        }

        static void Main(string[] args)
        {            
            Program obj= new Program();
            obj.Add(10, 20);
            obj.Add(10, " Srikanth");
            obj.Add("Welcome ", 20);
            obj.Add(10, 20, 30);
            Console.Read();
        }
    }
}
