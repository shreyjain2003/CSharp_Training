using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capgemini_Training
{
    /// <summary>
    /// Provides an entry point for generating and displaying a diamond-shaped pattern of asterisks in the console based
    /// on user input.
    /// </summary>
    /// <remarks>This class is intended for demonstration or educational purposes and is typically executed as
    /// a console application. The user is prompted to enter the number of rows for the upper half of the diamond, and
    /// the resulting pattern is printed to the standard output.</remarks>
    class Diamond_Pattern
    {
        static void Main(string[] args)
        {
            // Ask user for number of rows (half of the diamond)
            Console.WriteLine("Enter number of rows:");
            int n = int.Parse(Console.ReadLine());

            // -------------------------
            // Upper half of the diamond
            // -------------------------
            for (int i = 1; i <= n; i++)
            {
                // Print spaces
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int star = 1; star <= (2 * i - 1); star++)
                {
                    Console.Write("*");
                }

                // Move to next line
                Console.WriteLine();
            }

            // -------------------------
            // Lower half of the diamond
            // -------------------------
            for (int i = n - 1; i >= 1; i--)
            {
                // Print spaces
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int star = 1; star <= (2 * i - 1); star++)
                {
                    Console.Write("*");
                }

                // Move to next line
                Console.WriteLine();
            }
        }
    }
}
