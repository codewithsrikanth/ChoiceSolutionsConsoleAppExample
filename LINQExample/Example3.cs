using System;
using System.Linq;

namespace LINQExample
{
    class Example3
    {
        static void Main(string[] args)
        {
            CompanyDBDataContext db = new CompanyDBDataContext();
            var emps = db.Employees.ToList();
            foreach (var emp in emps)
            {
                Console.WriteLine($"{emp.Eno}   -       {emp.Ename}         -       {emp.Job}");
            }

            Console.WriteLine("Enter Eno: ");
            int eno = Convert.ToInt32(Console.ReadLine());
            var emp1 = db.Employees.Where(emp=>emp.Eno == eno).FirstOrDefault();
            Console.WriteLine($"{emp1.Eno}   -       {emp1.Ename}         -       {emp1.Job}");

            Console.WriteLine("Enter Employee Details: ");
            Employee obj = new Employee()
            {
                Eno = Convert.ToInt32(Console.ReadLine()),
                Ename = Console.ReadLine(),
                Job = Console.ReadLine(),
                Salary = Convert.ToDecimal(Console.ReadLine()),
                Dname = Console.ReadLine()
            };
            db.Employees.InsertOnSubmit(obj);
            db.SubmitChanges();
            Console.Read();
        }
    }
}
