using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Provides a console application for generating and displaying the Fibonacci series up to a specified number of
    /// terms.
    /// </summary>
    /// <remarks>This class is intended to be used as a standalone program. It prompts the user for input and
    /// outputs the Fibonacci sequence to the console. The class is not intended for use as a library
    /// component.</remarks>
    public class Fibonacci_Series
    {
        static void Main()
        {
            // Ask the user to enter the number of terms
            Console.Write("Enter number of terms: ");

            // Read input from the user and convert it to integer
            int n = int.Parse(Console.ReadLine());

            // First two terms of Fibonacci series
            int a = 0;
            int b = 1;

            // Display heading
            Console.WriteLine("Fibonacci Series:");

            // Loop to generate Fibonacci terms
            for (int i = 1; i <= n; i++)
            {
                // Print the current term
                Console.Write(a + " ");

                // Calculate the next term
                int next = a + b;

                // Update values for next iteration
                a = b;
                b = next;
            }
        }
    }

}
