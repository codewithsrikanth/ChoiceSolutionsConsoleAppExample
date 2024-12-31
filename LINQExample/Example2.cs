using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
        public int DeptID { get; set; }
    }
    internal class Example2
    {
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id = 1,Name = "Srikanth",Salary=20000,DOJ = new DateTime(2013,01,04),DeptID=10},
                new Employee(){Id = 2,Name = "Raju",Salary=25000,DOJ = new DateTime(2015,01,04),DeptID=10},
                new Employee(){Id = 3,Name = "Ramesh",Salary=18000,DOJ = new DateTime(2013,01,04),DeptID=20},
                new Employee(){Id = 4,Name = "Suresh",Salary=31000,DOJ = new DateTime(2014,01,04),DeptID=30},
                new Employee(){Id = 5,Name = "Rajesh",Salary=16000,DOJ = new DateTime(2017,01,04),DeptID=10},
                new Employee(){Id = 6,Name = "Phani",Salary=32000,DOJ = new DateTime(2014,01,04),DeptID=20},
                new Employee(){Id = 7,Name = "Vasu",Salary=12000,DOJ = new DateTime(2018,01,04),DeptID=30}
            };
            return employees;
        }
        static void Main(string[] args)
        {
            var employees = GetEmployees();
            //Query Syntax
            //var emps = from emp in employees select emp;
            //var emps = from emp in employees where emp.Name.StartsWith("R") select emp;
            //var emps = from emp in employees where emp.Name.Contains("S") && emp.Salary > 20000 select emp;
            //var emps = from emp in employees where emp.Name.Contains("S") || emp.Salary > 20000 select emp;
            //var emps = from emp in employees where emp.Salary > 23000 orderby emp.Name select emp;
            //var emps = from emp in employees group emp by emp.DeptID;
            //var emps = from emp in employees orderby emp.Salary descending select emp;
            ////var topSalary = emps.Take(1);
            //var res1 = emps.Skip(2);
            //var res2 = res1.Take(1);


            //Method Syntax
            //var emps = employees.ToList();
            //var emps = employees.Where(emp => emp.Name.StartsWith("R")).ToList();
            //var emps = employees.Where(e => e.Name.Contains("S") && e.Salary > 20000).ToList();
            //var emps = employees.Where(x=>x.Salary > 23000).OrderBy(x=>x.Name).ToList();
            //var emps = employees.GroupBy(x => x.DeptID);
            var emps = employees.OrderByDescending(x => x.Salary).ToList();
            var res1 = emps.Skip(3);
            var res2 = res1.Take(1);
            Console.WriteLine("Employees are: ");
            foreach (var emp in res2)    
            {
                Console.WriteLine($"{emp.Id}    -   {emp.Name}  -   {emp.Salary}    -   {emp.DOJ}   -   {emp.DeptID}");
            }
            //foreach (var item in emps)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var emp in item)
            //    {
            //        Console.WriteLine($"{emp.Id}    -   {emp.Name}  -   {emp.Salary}    -   {emp.DOJ}   -   {emp.DeptID}");
            //    }
            //}

            Console.Read();
        }
    }
}
