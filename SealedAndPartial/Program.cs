using System;

namespace SealedAndPartial
{
    class C1
    {
        public void F1()
        {
            Console.WriteLine("This is F1() - C1 class");
        }
        public virtual void Display()
        {
            Console.WriteLine("This is C1 class Display function");
        }
    }
    class C2 : C1
    {
        public void F2()
        {
            Console.WriteLine("This is F2() - C2 class");
        }
        public sealed override void Display()
        {
            Console.WriteLine("This is C2 class Display fucntion");
        }
    }
    sealed class C3 : C2
    {
        public void F3()
        {
            Console.WriteLine("This is F3() - C3 class");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            C3 obj = new C3();
            obj.F1();
            obj.F2();
            obj.F3();
            Console.Read();
        }
    }
}
