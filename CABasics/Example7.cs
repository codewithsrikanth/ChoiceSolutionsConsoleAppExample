using System;

namespace CABasics
{
    class Example7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  3 numbers");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            int num3=Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.WriteLine("Num1 is Bigger");
            else if (num2 > num3)
                Console.WriteLine("Num2 is Bigger");
            else
                Console.WriteLine("Num3 is Bigger");



            //if(num1>=num2 && num1>=num3)
            // {
            //     Console.WriteLine("Biggest number :" + num1);
            // }

            // else if (num2 >= num1 && num2 >= num3)
            // {
            //     Console.WriteLine("Biggest number :" + num2);
            // }
            // else 
            // {
            //     Console.WriteLine("Biggest number :" + num3);
            // }

            // if (num1 <= num2 && num1 <= num3)
            // {
            //     Console.WriteLine("smallest number :" + num1);
            // }
            // else if (num2 <= num1 && num2 <= num3)
            // {
            //     Console.WriteLine("Biggest number :" + num2);
            // }

            // else
            // {
            //     Console.WriteLine("Biggest number :" + num3);
            // }





            Console.Read();
        }
    }
}
