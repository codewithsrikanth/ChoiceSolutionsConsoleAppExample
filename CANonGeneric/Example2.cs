using System;
using System.Collections;

namespace CANonGeneric
{
    internal class Example2
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Initial Capacity: "+ al.Capacity);
            //Console.WriteLine("Initial Count: "+ al.Count);
            //al.Add(100);            
            //al.Add(100);
            //Console.WriteLine("After Capacity: " + al.Capacity);
            //Console.WriteLine("After Count: " + al.Count);

            ArrayList al = new ArrayList();
            al.Add(100);al.Add(200);al.Add(300);
            al.Add(400);al.Add(500);al.Add(600);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();
            al.AddRange(new int[] {700,800,900 });
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();
            al.Insert(1, 250);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();
            al.InsertRange(2, new object[] {"Hello","Welcome",1234.567,true });
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();
            al.Remove(true);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();
            al.RemoveAt(1);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();
            al.RemoveRange(1, 3);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();
            Console.Read();
        }
    }
}
