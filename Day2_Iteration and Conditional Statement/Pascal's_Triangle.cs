using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capgemini_Training
{
    /// <summary>
    /// Provides a console application that displays Pascal's Triangle up to a specified number of rows entered by the
    /// user.
    /// </summary>
    /// <remarks>This class is intended to be run as a standalone application. The program prompts the user to
    /// enter the number of rows and then prints Pascal's Triangle in a formatted manner to the console. Input must be a
    /// valid non-negative integer; otherwise, a runtime exception may occur.</remarks>
    class Pascals_Triangle
    {
        static void Main(string[] args)
        {
            // Ask user for number of rows
            Console.Write("Enter number of rows: ");
            int n = int.Parse(Console.ReadLine());

            // Loop for each row
            for (int i = 0; i < n; i++)
            {
                int number = 1; // First value in every row is always 1

                // Print spaces for triangle shape
                for (int space = 0; space < n - i - 1; space++)
                {
                    Console.Write(" ");
                }

                // Loop to print numbers in each row
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number + " ");

                    // Formula to calculate next value in the row
                    number = number * (i - j) / (j + 1);
                }

                // Move to next line after each row
                Console.WriteLine();
            }
        }
    }
}

