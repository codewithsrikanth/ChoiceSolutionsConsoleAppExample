using System;
using System.Configuration;
using System.Data.SqlClient;

namespace CADatabase
{
    class Example5
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ChoiceConn"].ConnectionString);
            Console.WriteLine("Enter Eno: ");
            int eno = Convert.ToInt32(Console.ReadLine());
            string query = "select Ename, Salary from Employee where Eno="+eno;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            var res = cmd.ExecuteScalar();
            con.Close();
            Console.WriteLine("Employee Name is: "+res);
            Console.Read();
        }
    }
}
