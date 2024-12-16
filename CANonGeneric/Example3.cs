using System;
using System.Collections;

namespace CANonGeneric
{
    internal class Example3
    {
        //static void Display(int x)
        //{
        //    Console.WriteLine("Value of x is: "+x);
        //}
        //static void Display(bool x)
        //{
        //    Console.WriteLine("Value of x is: " + x);
        //}
        //static void Display(string x)
        //{
        //    Console.WriteLine("Value of x is: " + x);
        //}
        //static void Display(float x)
        //{
        //    Console.WriteLine("Value of x is: " + x);
        //}

        static void Display<Sri>(Sri x)
        {
            Console.WriteLine("Value of x is: " + x);
        }

        static void Main(string[] args)
        {
            Display<int>(100); 
            Display<string>("Welcome");


            Hashtable ht = new Hashtable();
            ht.Add("EmpId", 101);
            ht.Add("EmpName", "Srikanth");
            ht.Add("EmpSalary", 1234.56);
            ht.Add("isActive", true);
            ht.Add("Exp", "10Yrs");

            

            foreach (var key in ht.Keys)
            {
                Console.WriteLine(key+" --> " + ht[key]);
            }

            Console.WriteLine("EmpID".GetHashCode());

            Console.Read();
        }
    }
}
