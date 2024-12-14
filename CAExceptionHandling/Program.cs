using System;

namespace CAExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            try
            {                
                Console.WriteLine("Enter two numbers: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("Second number can't be zero");
                }
                else
                {
                    res = num1 / num2;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            //catch
            //{
            //    Console.WriteLine("Exception occured");
            //}
            finally
            {
                Console.WriteLine("Result is: " + res);
                Console.Read();
            }          
           
        }
    }
}
