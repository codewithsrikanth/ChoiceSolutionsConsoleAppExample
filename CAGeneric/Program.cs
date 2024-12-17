using System;

namespace CAGeneric
{
    class Arthematic<T, S>
    {
        public void Add(T x, S y)
        {
            dynamic a = x;
            dynamic b = y;
            Console.WriteLine("Addition is: "+(a+b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic obj1 = new Arthematic<int, int>();
            obj1.Add(100, 200);

            Arthematic<string,int> obj2 = new Arthematic<string, int>();
            obj2.Add("Welcome ", 1234);

            Console.Read();
        }
    }
}
