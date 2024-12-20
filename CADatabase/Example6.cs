using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CADatabase
{
    class Example6
    {
        static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee>();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ChoiceConn"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Employee emp = new Employee();
                    emp.Eno = Convert.ToInt32(dr["Eno"]);
                    emp.Ename = Convert.ToString(dr["Ename"]);
                    emp.Job = Convert.ToString(dr["Job"]);
                    emp.Salary = Convert.ToDouble(dr["Salary"]);
                    emp.Dname = Convert.ToString(dr["Dname"]);
                    emps.Add(emp);
                }
                dr.Close();
                con.Close();
            }
            else
            {
                Console.WriteLine("No Records available");
            }
            if (emps.Count > 0)
            {
                foreach (var item in emps)
                {
                    Console.WriteLine($"{item.Eno}  -   {item.Ename}    -   {item.Job}  -   {item.Salary}   -   {item.Dname}");
                }
            }
           
            Console.Read();
        }
    }
}
