using System;

namespace CAProperties
{
    class Employee
    {
        int empId = 102; string empName;
        double empAge;

        //Auto-Implemented Properties
        public string FirstName { get; set; }

        //Read-Write
        public string EmployeeName
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    empName = value;
                }
                else
                {
                    Console.WriteLine("Name can't be blank");
                }

            }
            get { return empName; }
        }
        //Read-Only
        public int EmpID
        {
            get { return empId; }
        }
        //Write-Only
        public double EmployeeAge
        {
            set { empAge = value; }
        }
        //public int GetEmpID()
        //{
        //    return empId;
        //}
        ////Setting the value
        //public void SetEmpName(string empName)
        //{
        //    this.empName = empName;
        //}
        ////Get the value
        //public string GetEmpName()
        //{
        //    return empName;
        //}

    }
    class Student : Employee
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.EmployeeName = " ";
            Console.WriteLine(obj.EmployeeName);

            //obj.EmpID = 102;
            Console.WriteLine(obj.EmpID);

            obj.EmployeeAge = 35;
            //Console.WriteLine(obj.EmployeeAge);

            obj.FirstName = "Rallabandi";
            Console.WriteLine(obj.FirstName);

            //Console.WriteLine(obj.GetEmpID());
            //obj.SetEmpName("Srikanth");
            //Console.WriteLine(obj.GetEmpName());

            Console.Read();
        }
    }
}
