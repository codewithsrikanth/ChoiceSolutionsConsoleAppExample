using System;

namespace CABasics
{
    class Example12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size of an Array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Element - "+(i+1)+":");
                array[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("Elements of Array are: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
    }
}
