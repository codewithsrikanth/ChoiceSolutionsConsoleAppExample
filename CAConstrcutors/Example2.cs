using System;

namespace CAConstrcutors
{
    class Example2
    {
        static int i;
        int j;

        //Non-Static Constructor
        public Example2()
        {
            j = 10;
        }
        //Static Constructor
        static Example2()
        {
            i = 10;
        }
        public void Display()
        {
            Console.WriteLine("Value of i is: "+i);
            i++;
            Console.WriteLine("Value of j is: "+j);
            j++;
        }
    }
    class Sample
    {
        static void Main(string[] args)
        {
            Example2 obj1 = new Example2();
            obj1.Display();
            Example2 obj2 = new Example2();
            obj2.Display();
            Example2 obj3 = new Example2();
            obj3.Display();
            Console.Read();
        }
    }
}
