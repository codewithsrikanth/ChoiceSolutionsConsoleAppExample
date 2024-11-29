using System;

namespace CABasics
{
    class Example4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            //Simple If
            if(age >= 18)
            {
                Console.WriteLine("You are eligible to cast vote");
            }
            Console.WriteLine("Hello...!");

            Console.Read();
        }
    }
}
