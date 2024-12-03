using System;

namespace CABasics
{
    class Example11
    {
        static void Main(string[] args)
        {
            int[] ar = { 12, 43, 22, 87, 99, 54, 21, 50, 83, 33, 66, 98, 50 };
            ////Copy the elements into another array where element must be greater than 40
            //int size = 0;
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    if (ar[i] > 40)
            //    {
            //        size++;
            //    }
            //}
            //int[] ar2 = new int[size];

            int[] ar2 = new int[ar.Length];
            Array.Copy(ar, ar2, ar.Length);
            Array.Sort(ar2);
            Array.Reverse(ar2);
            foreach (int i in ar2)
            {
                Console.Write(i+" ");
            }
            Console.Read();
            




            

            
        }

    }
}
