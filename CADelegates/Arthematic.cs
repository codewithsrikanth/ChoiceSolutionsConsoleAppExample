using System;

namespace CADelegates
{
    class Arthematic
    {
        public int Add(int x, int y)
        {
            //Console.WriteLine("Addition is: " + (x + y));
            return x + y;
        }
        public int Sub(int x, int y)
        {
            //Console.WriteLine("Subtraction is: " + (x - y));
            return x - y;
        }
        public int Mul(int x, int y)
        {
            //Console.WriteLine("Mulitplication is: " + (x * y));            
            return x * y;
        }
    }
    class Example2
    {
        public delegate int DelArthematic(int x, int y);
        static void Main(string[] args)
        {
            Arthematic obj = new Arthematic();
            DelArthematic objD = new DelArthematic(obj.Add);
            objD += obj.Sub;
            objD += obj.Mul;
            Console.WriteLine(objD(200, 50)); 

            Console.Read();
        }
    }
}
