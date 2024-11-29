using System;

namespace CABasics
{
    class Example2
    {
        static void Main()
        {
            //Implicit Type Casting
            short x = 100;
            int y = x;
            double z = y;
            Console.WriteLine("Value of x is: "+x);
            Console.WriteLine("Value of y is: "+y);
            Console.WriteLine("Value of z is: "+z);

            //Explicit Type Casting
            //C++ Type casting
            double a = 12.34;
            int b = (int)a;
            short c = (short)b;
            Console.WriteLine("Value of a is: "+a);
            Console.WriteLine("Value of b is: "+b);
            Console.WriteLine("Value of c is: "+c);

            Console.Read();
        }
    }
}
