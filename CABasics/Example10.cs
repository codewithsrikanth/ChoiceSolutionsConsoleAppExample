using System;
using System.Diagnostics;
using System.Text;

namespace CABasics
{
    class Example10
    {
        static void Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();
            sw1.Start();
            string s = " ";
            for (int i = 0; i < 100000; i++)
            {
                s = s + i;
            }
            sw1.Stop();

            sw2.Start();
            StringBuilder sb = new StringBuilder();
            for (int i = 0;i < 100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();

            Console.WriteLine("Time for String modifictions: "+sw1.ElapsedMilliseconds);
            Console.WriteLine("Time for StringBuider modifictions: "+sw2.ElapsedMilliseconds);
            Console.Read();
        }
    }
}
