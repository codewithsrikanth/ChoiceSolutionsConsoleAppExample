using System;
using System.Collections.Generic;

namespace CAGeneric
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
    }
    class Example1
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee();
            //emp1.EmpId = 101;
            //emp1.EmpName = "Srikanth";
            //emp1.Salary = 1234.56;

            //Employee emp2 = new Employee();
            //emp2.EmpId = 102;
            //emp2.EmpName = "Raju";
            //emp2.Salary = 2345.76;

            //Employee emp3 = new Employee();
            //emp3.EmpId = 103;
            //emp3.EmpName = "Suresh";
            //emp3.Salary = 7654.98;

            ////Object Initilizer
            //Employee emp4 = new Employee()
            //{
            //    EmpId = 104,
            //    EmpName = "Ramesh",
            //    Salary = 3456.78
            //};



            ////List<Employee> emps = new List<Employee>();
            ////emps.Add(emp1);
            ////emps.Add(emp2);
            ////emps.Add(emp3);

            ////Object Initilizer
            //List<Employee> emps = new List<Employee>() { emp1, emp2, emp3, emp4 };


            //Collection Initilizers
            List<Employee> emps = new List<Employee>()
            {
                new Employee(){EmpId=101,EmpName="Srikanth",Salary=1234.56},
                new Employee(){EmpId=101,EmpName="Srikanth",Salary=1234.56},
                new Employee(){EmpId=101,EmpName="Srikanth",Salary=1234.56},
                new Employee(){EmpId=101,EmpName="Srikanth",Salary=1234.56},
                new Employee(){EmpId=101,EmpName="Srikanth",Salary=1234.56}
            };

            Console.WriteLine("Employees Details are");
            foreach (var emp in emps)
            {
                Console.WriteLine($"{emp.EmpId} - {emp.EmpName} - {emp.Salary}");
            }
            Console.Read();
        }
    }
}
