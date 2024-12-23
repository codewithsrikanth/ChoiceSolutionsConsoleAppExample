using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CADatabase
{
    class Example7
    {
        static void Main(string[] args)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ChoiceConn"].ConnectionString)) 
            {                
                SqlDataAdapter da = new SqlDataAdapter("select * from Employee", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Console.WriteLine("Employee Details are: ");
                foreach (DataRow dr in dt.Rows)
                {
                    Console.WriteLine($"{dr["Eno"]} -   {dr["Ename"]}   -   {dr["Job"]} -   {dr["Salary"]}  -   {dr["Dname"]}");
                }

                Console.WriteLine("Dataset Example");
                DataSet ds = new DataSet();
                da.Fill(ds, "EmpDetails");
                foreach (DataRow dr in ds.Tables["EmpDetails"].Rows)
                {
                    Console.WriteLine($"{dr["Eno"]} -   {dr["Ename"]}   -   {dr["Job"]} -   {dr["Salary"]}  -   {dr["Dname"]}");
                }
            }

            Console.Read();
        }
    }
}
