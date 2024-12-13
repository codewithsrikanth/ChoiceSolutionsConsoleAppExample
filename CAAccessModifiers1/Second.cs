using System;

namespace CAAccessModifiers1
{
    class Second : First
    {
        static void Main(string[] args)
        {
            Second obj = new Second();
            //obj.F1();
            obj.F2();
            obj.F3();
            obj.F4();
            obj.F5();
            obj.F6();
            Console.Read();
        }
    }
}
