using System;

namespace CABasics
{
    class Example8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
        Operator:
            Console.WriteLine("Enter an operator (+, -, /, *): ");
            char op = Convert.ToChar(Console.ReadLine());
            int res = 0;
            //if(op == '+')
            //    res = num1 + num2;
            //else if(op == '-')
            //    res = num1 - num2;
            //else if(op == '*')
            //    res = num1 * num2;
            //else if(op == '/')
            //    res = num1 / num2;
            //else
            //    Console.WriteLine("Invalid Operator");

            bool isInvalid = false;
            switch (op)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                case '%':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Second Number can't be zero");
                        isInvalid = true;
                    }
                    else
                        res = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    isInvalid = true;
                    goto Operator;
            }
            if (isInvalid == false)
                Console.WriteLine("Result is: " + res);
            Console.Read();
        
        }
    }
}
