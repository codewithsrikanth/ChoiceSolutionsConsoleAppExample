using System;

namespace CABasics
{
    class Example1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            double secondNum = double.Parse(Console.ReadLine());
            int addition = (int)(firstNum + secondNum);
            //int addition = int.Parse(firstNum + secondNum);
            Console.WriteLine("Addition is: "+addition);
            Console.Read();
        }
    }
}
