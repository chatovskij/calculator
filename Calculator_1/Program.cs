using System;

namespace Calculator_1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! This is a calculator program, v1.");

            double a;
            double b;
            double total;
            char oper;

            Console.WriteLine("Enter the first number:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator:");
            oper = Convert.ToChar(Console.ReadLine());

            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine("The result is: " + total + ".");
            }

            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("The result is: " + total + ".");
            }

            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("The result is: " + total + ".");
            }

            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine("The result is: " + total + ".");
            }
            else
            {
                Console.WriteLine("Unknown operator.");
            }
        }
    }
}
