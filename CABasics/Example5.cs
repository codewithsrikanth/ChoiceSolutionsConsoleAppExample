using System;

namespace CABasics
{
    class Example5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Email/Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            if(username == "admin@gmail.com" &&  password == "admin@123")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login Success...!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Credentials...!");
            }
            Console.Read();
        }
    }
}
