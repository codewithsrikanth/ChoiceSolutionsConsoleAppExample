using System;
using System.Collections;

namespace CANonGeneric
{    
    class Example1
    {
        static void Main(string[] args)
        {
            //int[] ar = new int[4] {12,34,45,65,77 };
            Stack s = new Stack(3);
            s.Push(100);s.Push("Srikanth");s.Push(1234.56);
            s.Push(3.14f);s.Push(true);
            Console.WriteLine("Elements of Stack are: ");
            foreach (var item in s)
                Console.Write(item + " ");
            Console.WriteLine();
            s.Pop();
            foreach (var item in s)
                Console.Write(item + " ");
            Console.WriteLine();
            
            Queue q = new Queue();
            q.Enqueue(100);q.Enqueue("Srikanth");q.Enqueue(true);
            q.Enqueue(1234.56);q.Enqueue(3.14f);
            Console.WriteLine("Elements of Queue are: ");
            foreach (var item in q)
                Console.Write(item + " ");
            Console.WriteLine();
            q.Dequeue();
            foreach (var item in q)
                Console.Write(item + " ");
            Console.WriteLine();

            Console.Read();
        }
    }
}
