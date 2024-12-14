using System;

namespace SealedAndPartial
{
    partial class Arthematic
    {
        public void Sub(int x, int y)
        {
            Console.WriteLine("Subtraction is: " + (x - y));
        }
    }
}
