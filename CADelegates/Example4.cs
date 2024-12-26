using System;

namespace CADelegates
{
    class Example4
    {
        //static void F1(int x, double y, float z)
        //{
        //    Console.WriteLine("Addition is: " + (x + y + z));
        //}
        //static double F2(int x, double y, float z)
        //{
        //    return x + y + z;
        //}
        //static bool F3(string name)
        //{
        //    if (name.Length < 5)
        //        return true;
        //    else
        //        return false;
        //}
        static void Main(string[] args)
        {
            Action<int, double, float> objD1 = (x,y,z) =>
            {
                Console.WriteLine("Addition is: " + (x + y + z));
            };
            Func<int, double, float, double> objD2 = (x, y, z) =>
            {
                return (x + y + z);
            };
            Predicate<string> objD3 = name =>
            {
                if(name.Length > 5)
                    return true;
                return false;
            };
            
            

            objD1(10, 12.34, 3.14f);
            Console.WriteLine(objD2(20, 45.67, 2.13f));
            Console.WriteLine(objD3("Srikanth"));

            Console.Read();
        }
    }
}
