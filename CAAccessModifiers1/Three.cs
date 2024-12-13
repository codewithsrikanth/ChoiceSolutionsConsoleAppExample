using System;

namespace CAAccessModifiers1
{
    class Three
    {
        static void Main(string[] args)
        {
            First obj = new First();
            //obj.F1();
            //obj.F2();
            obj.F3();
            obj.F4();
            //obj.F5();
            obj.F6();
            Console.Read();
        }
    }
}
