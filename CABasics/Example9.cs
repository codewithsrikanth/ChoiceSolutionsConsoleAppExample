using System;

namespace CABasics
{
    internal class Example9
    {
        static void Main(string[] args)
        {
            //int[] ar = new int[4] {12,34,56,34 };
            //int[] ar = { 100, 200, 300 };

            string[] courses = new string[7] { "C#.Net","ASP.Net","MVC","Web API","jQuery","Angular","React"};
            //Console.WriteLine(courses[0]);
            //Console.WriteLine(courses[1]);
            //Console.WriteLine(courses[2]);
            //Console.WriteLine(courses[3]);
            //Console.WriteLine(courses[4]);

            //for (int i = 0;i< courses.Length;i++)
            //    Console.Write(courses[i]+", ");

            //int i = 0;
            //while(i < courses.Length)
            //{
            //    Console.Write(courses[i]+", ");
            //    i++;
            //}

            foreach(string course in courses)
            {
                Console.Write(course+", ");
            }



            Console.Read();
        }
    }
}
