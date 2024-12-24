using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CADatabase
{
    class Example8
    {
        static void Main(string[] args)
        {
            //Step-1
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ChoiceConn"].ConnectionString))
            {
                //Step-2
                SqlDataAdapter da = new SqlDataAdapter("select * from Employee", con);
                //3
                DataSet ds = new DataSet();
                SqlCommandBuilder bldr = new SqlCommandBuilder(da);               
                da.Fill(ds, "Employee");

                foreach (DataRow dr in ds.Tables["Employee"].Rows)
                {
                    Console.WriteLine($"{dr["Eno"]} -   {dr["Ename"]}   -   {dr["Job"]} -   {dr["Salary"]}  -   {dr["Dname"]}");
                }
                //4
                //Insert
                DataRow row = ds.Tables["Employee"].NewRow();
                row["Eno"] = 117;
                row["Ename"] = "Abhi";
                row["Job"] = "Admin";
                row["Salary"] = 1234.5;
                row["Dname"] = "Administration";
                ds.Tables["Employee"].Rows.Add(row);

                //5
                if (ds.HasChanges())
                {
                    da.Update(ds.Tables["Employee"]);
                    Console.WriteLine("Record(s) updated on DB");
                }
            }
            Console.Read();
        }
    }
}
