using System;

namespace CABasics
{
    class Example14
    {
        static void Main(string[] args)
        {
            //datatype[] varible = new datatype[size]{elements};
            //datatype[,] varible = new datatype[rowsize,colsize]{elements};
            //Jagged Array
            //datatype[][] variable = new datatype[numberofelements][]{};
            int[][] ar = new int[3][];
            ar[0] = new int[5] {12,23,34,45,66 };
            ar[1] = new int[3] { 65, 43, 32 };
            ar[2] = new int[2] { 98, 54 };
            Console.WriteLine("Elements of Jagged Array are: ");
            foreach (int[] item in ar)
            {
                foreach (int value in item)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }   
}
