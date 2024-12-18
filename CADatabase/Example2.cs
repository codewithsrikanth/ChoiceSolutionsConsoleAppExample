using System;
using System.Data.SqlClient;

namespace CADatabase
{
    class Example2
    {
        static void Main(string[] args)
        {
            try
            {
                //Estb Connection
                SqlConnection con = new SqlConnection("server=.;integrated security=true;database=CompanyDB");

                //Prepare the query and pass
                Console.WriteLine("Enter Eno: ");
                int eno = Convert.ToInt32(Console.ReadLine());
                string query = "delete from Employee where Eno=" + eno;
                SqlCommand cmd = new SqlCommand(query, con);

                //Open Connection
                con.Open();

                //Execute Query
                int rowCount = cmd.ExecuteNonQuery();

                //Close connection
                con.Close();

                if (rowCount > 0)
                {
                    Console.WriteLine("Record Deleted");
                }
                else
                {
                    Console.WriteLine("No Record found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.Read();
        }
    }
}
