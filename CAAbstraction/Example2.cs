using System;

namespace CAAbstraction
{
    class C1
    {
        public void F1()
        {
            Console.WriteLine("This is F1()");
        }
    }
    interface I1
    {
        void F2();
    }
    interface I2
    {
        void F2();
    }
    class Example2 : C1, I1, I2
    {
        static void Main(string[] args)
        {
            //Object Creation
            //Object Instatiation
            //Object referecing

            Example2 obj = new Example2();
            obj.F1();
            I1 obj1 = obj;
            obj1.F2();
            I2 obj2 = obj;
            obj2.F2();


            //obj.F2();
            Console.Read();
        }

        //Explicit Interface Implementation
        void I1.F2()
        {
            Console.WriteLine("This is F2() from I1 interface");
        }

        void I2.F2()
        {
            Console.WriteLine("This is F2() from I2 interface");
        }


        //public void F2()
        //{
        //    Console.WriteLine("This is F2() implementation");
        //}
    }
}
