using System;

namespace CAInheritance
{
    class Employee
    {
        int id; string name; double salary;
        public void GetEmpData()
        {
            Console.WriteLine("Enter Employee Details: ");
            id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            salary = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayEmpData()
        {
            Console.WriteLine($"EmpID: {id}, EmpName: {name}, Salary: {salary}");
        }
    }
    //Inheritance
    class Trainer : Employee
    {
        string subName;
        public void GetTrainerData()
        {
            base.GetEmpData();
            Console.WriteLine("Enter Subject: ");
            subName = Console.ReadLine();
        }
        public void DisplaySubject()
        {
            base.DisplayEmpData();
            Console.WriteLine("Subject is: "+subName);
        }
    }
    class Admin : Employee
    {
        string adminCategory;
        public void GetAdminData()
        {
            base.GetEmpData();
            Console.WriteLine("Enter Admin Catagory: ");
            adminCategory = Console.ReadLine();
        }
        public void DisplayAdminData()
        {
            base.DisplayEmpData();
            Console.WriteLine("Admin Catagory is: "+adminCategory);
        }
    }
    class Department : Trainer
    {
        int deptId;string deptName;
        public void GetDepartmentData()
        {
            base.GetTrainerData();
            Console.WriteLine("Enter Department Details: ");
            deptId = Convert.ToInt32(Console.ReadLine());
            deptName = Console.ReadLine();
        }
        public void DisplayDeptData()
        {
            base.DisplaySubject(); 
            Console.WriteLine($"DeptID is: {deptId} and Deptname is: {deptName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Department empData = new Department();
            empData.GetDepartmentData();
            empData.DisplayDeptData();           

            Console.Read();
        }
    }
}
