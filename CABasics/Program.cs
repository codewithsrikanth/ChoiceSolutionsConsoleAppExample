using System;

namespace CABasics
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#.Net");
            Console.WriteLine("Enter your name: ");
            //int name = Console.Read(); //It is used to take the input from the user
            string name = Console.ReadLine();
            Console.WriteLine("My name is: " + name);
        }
    }
}
