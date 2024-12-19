using System;
using System.Configuration;
using System.Data.SqlClient;

namespace CADatabase
{
    class Employee
    {
        public int Eno { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Dname { get; set; }
    }
    class Example3
    {
        public static Employee GetEmployee()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter Employee Details: ");
            employee.Eno = Convert.ToInt32(Console.ReadLine());
            employee.Ename = Console.ReadLine();
            employee.Job = Console.ReadLine();
            employee.Salary = Convert.ToDouble(Console.ReadLine());
            employee.Dname = Console.ReadLine();
            return employee;
        }

        static void Main(string[] args)
        {
            string constr = ConfigurationManager.ConnectionStrings["ChoiceConn"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);

            Employee emp = GetEmployee();

            //string query = "insert into Employee values("+emp.Eno+",'"+emp.Ename+"','"+emp.Job+"',"+emp.Salary+",'"+emp.Dname+"')";

            string query = $"insert into Employee values({emp.Eno},'{emp.Ename}','{emp.Job}',{emp.Salary},'{emp.Dname}')";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            int recCount = cmd.ExecuteNonQuery();
            con.Close();

            Console.WriteLine(recCount+" Record(s) Affected");
            Console.Read();
        }
    }
}
