using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Provides an entry point for determining whether a user-input number is a Strong Number.
    /// </summary>
    /// <remarks>A Strong Number is a number for which the sum of the factorials of its digits equals the
    /// number itself. This class prompts the user to enter a number via the console and outputs whether the entered
    /// number is a Strong Number. This class is intended for demonstration and console-based interaction.</remarks>
    class Strong_Number
    {
        static void Main(string[] args)
        {
            // Ask user to enter a number
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int originalNumber = number; // Store original number
            int sum = 0;                 // To store sum of factorials

            // Loop to extract each digit
            while (number > 0)
            {
                int digit = number % 10; // Get last digit
                int fact = 1;

                // Calculate factorial of the digit
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                }

                sum = sum + fact; // Add factorial to sum
                number = number / 10; // Remove last digit
            }

            // Check if sum equals original number
            if (sum == originalNumber)
            {
                Console.WriteLine(originalNumber + " is a Strong Number");
            }
            else
            {
                Console.WriteLine(originalNumber + " is NOT a Strong Number");
            }
        }
    }
}

