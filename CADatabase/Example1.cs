using System;
using System.Data.SqlClient;

namespace CADatabase
{
    class Example1
    {
        static void Main(string[] args)
        {
            try
            {
                string connstr = "server=.;integrated security=true;database=CompanyDB";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connstr;
                con.Open();
                Console.WriteLine("Connection Opened");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.Read();
            }
           
        }
    }
}
