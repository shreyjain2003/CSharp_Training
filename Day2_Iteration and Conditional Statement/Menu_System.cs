using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Provides a simple console-based menu system for performing basic arithmetic operations, including addition,
    /// subtraction, multiplication, and division.
    /// </summary>
    /// <remarks>The menu prompts the user to select an operation and enter two integer values. The program
    /// continues to display the menu until the user chooses to exit. Division by zero is not permitted and will result
    /// in an error message. This class is intended for demonstration or educational purposes and is designed to be run
    /// as a console application.</remarks>
    class Menu_System
    {
        static void Main(string[] args)
        {
            int choice;

            // do-while loop ensures menu runs at least once
            do
            {
                // Display menu options
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                // Read user choice
                choice = int.Parse(Console.ReadLine());

                // switch statement to handle menu options
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter first number: ");
                        int a1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        int b1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result = " + (a1 + b1));
                        break;

                    case 2:
                        Console.Write("Enter first number: ");
                        int a2 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        int b2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result = " + (a2 - b2));
                        break;

                    case 3:
                        Console.Write("Enter first number: ");
                        int a3 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        int b3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result = " + (a3 * b3));
                        break;

                    case 4:
                        Console.Write("Enter first number: ");
                        int a4 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        int b4 = int.Parse(Console.ReadLine());

                        // Check to avoid division by zero
                        if (b4 != 0)
                            Console.WriteLine("Result = " + (a4 / b4));
                        else
                            Console.WriteLine("Division by zero is not allowed!");
                        break;

                    case 5:
                        Console.WriteLine("Exiting program... Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

            } while (choice != 5); // Loop continues until user selects Exit
        }
    }
}
