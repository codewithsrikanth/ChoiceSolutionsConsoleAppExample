using System;

namespace CAAbstraction
{
    abstract class Employee
    {
        public int empId;public string empName;public double empSalary;
        public void GetData()
        {
            Console.WriteLine("Enter Employee Details: ");
            empId = Convert.ToInt32(Console.ReadLine());
            empName = Console.ReadLine();
            empSalary = Convert.ToDouble(Console.ReadLine());
        }
        public abstract double CalSalary(int hrs);
    }
    class Trainer : Employee
    {
        public override double CalSalary(int hrs)
        {
            return base.empSalary + (hrs * 3000);
        }
        public void DisplayTrainerInfo()
        {
            Console.WriteLine($"EmpID: {base.empId} - EmpName: {base.empName} and Total Salary: {CalSalary(8)}");
        }
    }
    class Admin : Employee
    {
        public override double CalSalary(int hrs)
        {
            return base.empSalary + (hrs * 2000);
        }
        public void DisplayAdminInfo()
        {
            Console.WriteLine($"EmpID: {base.empId} - EmpName: {base.empName} and Total Salary: {CalSalary(8)}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trainer obj1 = new Trainer();
            obj1.GetData();
            obj1.DisplayTrainerInfo();

            Admin obj2 = new Admin();
            obj2.GetData();
            obj2.DisplayAdminInfo();

            Console.Read();
        }
    }
}
