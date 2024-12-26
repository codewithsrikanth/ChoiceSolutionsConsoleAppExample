using System;

namespace CADelegates
{
    public delegate void Del1(int a, double b, float c);
    public delegate double Del2(int a, double b, float c);
    public delegate bool Del3(string name);
    class Example3
    {
        //static void F1(int x,double y, float z)
        //{
        //    Console.WriteLine("Addition is: "+(x+y+z));
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
            //Del1 objD1 = new Del1(F1);
            //Del2 objD2 = new Del2(F2);
            //Del3 objD3 = new Del3(F3);

            //Anonymous method - 4.0
            //Del1 objD1 = delegate (int x, double y, float z)
            //{
            //    Console.WriteLine("Addition is: " + (x + y + z));
            //};
            //Del2 objD2 = delegate (int a, double b, float c)
            //{
            //    return (a + b + c);
            //};
            //Del3 objD3 = delegate (string name)
            //{
            //    if (name.Length < 5)
            //        return true;
            //    else
            //        return false;
            //};

            //Lambda Expression - 5.0
            Del1 objD1 = (a, b, c) =>
            {
                Console.WriteLine("Addition is: " + (a + b + c));
            };
            Del2 objD2 = (x, y, z) =>
            {
                return x + y + z;
            };
            Del3 objD3 = name =>
            {
                if (name.Length == 3)
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
