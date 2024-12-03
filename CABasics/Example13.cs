using System;

namespace CABasics
{
    class Example13
    {
        static void Main(string[] args)
        {
            int[,] ar = new int[3, 4] { { 12, 34, 45, 56 }, { 45, 56, 78, 98 }, { 12, 32, 43, 54 } };

            Console.WriteLine("Elements of Array are: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(ar[i, j]+"  ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
