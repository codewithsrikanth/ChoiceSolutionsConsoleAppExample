using CLibArthematic;
using System;

namespace CAArthematic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Arthematic obj = new Arthematic();
            Console.WriteLine("Addition is: "+obj.Add(num1,num2));
            Console.WriteLine("Subtraction is: "+obj.Sub(num1,num2));
            Console.WriteLine("Mulitplication is: "+obj.Mul(num1,num2));
            Console.Read();
        }
    }
}
