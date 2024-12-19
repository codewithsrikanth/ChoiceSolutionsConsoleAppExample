using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CADatabase
{
    class Example4
    {        
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ChoiceConn"].ConnectionString);
            SqlCommand cmd = new SqlCommand("[dbo].[sp_InsertRec]", con);
            cmd.CommandType = CommandType.StoredProcedure;

            Employee emp = Example3.GetEmployee();

            //SqlParameter p1 = new SqlParameter();
            //p1.ParameterName = "@eno";
            //p1.Value = emp.Eno;
            cmd.Parameters.AddWithValue("@eno", emp.Eno);
            cmd.Parameters.AddWithValue("@ename", emp.Ename);
            cmd.Parameters.AddWithValue("@job", emp.Job);
            cmd.Parameters.AddWithValue("@salary", emp.Salary);
            cmd.Parameters.AddWithValue("@dname", emp.Dname);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine(i+" Record(s) affected");
            Console.Read();
        }
    }
}
