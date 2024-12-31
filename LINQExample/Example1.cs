using System;
using System.Linq;

namespace LINQExample
{
    class Example1
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 34, 56, 32, 21, 54, 36, 98, 87, 76, 56, 88, 11, 9, 1 };
            //query syntax
            //var brr = from x in arr select x;
            //var brr = from x in arr where x > 30 select x;
            //var brr = from x in arr where x > 30 orderby x ascending select x;

            //Method Syntax
            //var brr = arr.ToList();
            //var brr = arr.Where(x => x > 30).ToList();
            var brr = arr.Where(x => x > 30).OrderByDescending(x => x).ToList();


            Console.WriteLine("Elements of Array are: ");
            foreach (var x in brr) Console.Write(x + " ");
            Console.Read();
        }
    }
}
