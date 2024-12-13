using System;

namespace CAAccessModifiers1
{
    public class First
    {
        private void F1()
        {
            Console.WriteLine("Private Method");
        }
        protected void F2()
        {
            Console.WriteLine("Protected Method");
        }
        internal void F3()
        {
            Console.WriteLine("Internal Method");
        }
        protected internal void F4()
        {
            Console.WriteLine("Protected Internal Method");
        }
        private protected void F5()
        {
            Console.WriteLine("Private Protected Method");
        }
        public void F6()
        {
            Console.WriteLine("Public Method");
        }
        static void Main(string[] args)
        {
            First obj = new First();
            obj.F1();
            obj.F2();
            obj.F3();
            obj.F4();
            obj.F5();
            obj.F6();
            Console.Read();
        }
    }
}
