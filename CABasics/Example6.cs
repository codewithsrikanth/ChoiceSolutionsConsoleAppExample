using System;

namespace CABasics
{
    class Example6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username: ");
            string username = Console.ReadLine();
            if(username == "admin@gmail.com")
            {
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                if(password == "admin@123")
                {
                    Console.WriteLine("Enter your Role: ");
                    string role = Console.ReadLine();
                    if(role == "admin")
                    {
                        Console.WriteLine("Welcome Admin...!");
                    }
                    else
                    {
                        Console.WriteLine("Welcome User..!");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Password..!");
                }
            }
            else
            {
                Console.WriteLine("Username is Incorrect..!");
            }

            Console.Read();
        }
    }
}
