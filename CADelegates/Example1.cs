using System;

namespace CADelegates
{
    //Step-1
    public delegate void DelAdd(int x, int y);
    
    class Example1
    {
        static void Add(int x,int y)
        {
            Console.WriteLine("Addition is: "+(x+y));
        }
        static void Main(string[] args)
        {
            //Step-2
            DelAdd objD = new DelAdd(Add);
            //Step-3
            objD(100, 200);
            Console.Read();
        }
    }
}
