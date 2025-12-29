using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capgemini_Training
{
    /// <summary>
    /// Provides a console application for calculating the digital root of a user-entered integer.
    /// </summary>
    /// <remarks>The digital root is obtained by repeatedly summing the digits of a number until a
    /// single-digit value is produced. This class is intended for use as a standalone application and is not designed
    /// to be used as a library or instantiated from other code.</remarks>
    class Digital_Root
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            // Repeat the process until the number becomes a single digit
            while (num >= 10)
            {
                int sum = 0;

                // Calculate sum of digits
                while (num > 0)
                {
                    int digit = num % 10;   // Get last digit
                    sum += digit;           // Add digit to sum
                    num /= 10;              // Remove last digit
                }

                // Assign sum back to num for next iteration
                num = sum;
            }

            // Print the final single digit (digital root)
            Console.WriteLine("Digital Root is: " + num);
        }
    }
}

