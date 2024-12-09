using System;

namespace CAConstrcutors
{
    //Class
    class Employee
    {
        int empId; string empName; double salary;
        string city;string state;
        //User-Defined Default Constructor
        public Employee()
        {
            empId = 101;
            empName = "Srikanth";
            salary = 12345.67;
        }
        //Parameter Constructor
        public Employee(int empId, string empName, double sal)
        {
            //this - current class instance/object
            this.empId = empId;
            this.empName = empName;
            salary = sal;
        }
        public Employee(string city, string state)
        {
            this.state = state;
            this.city = city;
        }
        //Copy Construtor
        public Employee(string empName, Employee obj)
        {
            this.empName= empName;
            this.city = obj.city;
            this.state = obj.state;
        }
        //Method
        public void Display()
        {
            Console.WriteLine($"EmpID: {empId}, EmpName: {empName} and Salary: {salary}");
            Console.WriteLine($"City: {city} and State: {state}");
        }
        //Destructor
        ~Employee()
        {
            Console.WriteLine("This is a destructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee address = new Employee("Hyderabad", "Telangana");


            Employee emp = new Employee();
            emp.Display();

            Employee emp1 = new Employee(102, "Hari", 87654.98);
            emp1.Display();

            Employee emp2 = new Employee("Diyansh", address);
            emp2.Display();
            

            Console.Read();
        }
    }
}
