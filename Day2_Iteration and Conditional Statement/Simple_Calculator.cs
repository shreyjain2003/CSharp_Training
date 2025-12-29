using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Provides a simple command-line calculator for performing basic arithmetic operations on two numbers.
    /// </summary>
    /// <remarks>The calculator supports addition, subtraction, multiplication, and division. Input is read
    /// from the console, and results are displayed to the user. Division by zero is handled with an error
    /// message.</remarks>
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            // Input first number
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            // Input operator
            Console.Write("Enter operator (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            // Input second number
            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            // Switch case for operations
            switch (op)
            {
                case '+':
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;

                case '/':
                    if (num2 != 0)
                        Console.WriteLine("Result: " + (num1 / num2));
                    else
                        Console.WriteLine("Cannot divide by zero!");
                    break;

                default:
                    Console.WriteLine("Invalid Operator!");
                    break;
            }
        }
    }
}

