using System;

namespace CABasics
{
    class Example3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your Experience: ");
            int exp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Increment: ");
            short increment = Convert.ToInt16(Console.ReadLine());

            //string total = (string)(salary + (increment / 100));
            //string total = string.Parse(salary + (increment / 100));
            string total = Convert.ToString(salary + ((salary * increment) / 100));

            Console.WriteLine("Name is: "+firstName+" "+lastName);
            Console.WriteLine("Experience is: "+exp);
            Console.WriteLine("Total Salary is: " + total);

            Console.Read();
        }
    }
}
