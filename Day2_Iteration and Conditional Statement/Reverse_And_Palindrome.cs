using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capgemini_Training
{
    /// <summary>
    /// Provides an entry point for a console application that reads an integer from the user, displays its reverse, and
    /// indicates whether the number is a palindrome.
    /// </summary>
    /// <remarks>A palindrome number is a number that remains the same when its digits are reversed. This
    /// application prompts the user to enter a number, computes its reverse, and determines if the original and
    /// reversed numbers are equal.</remarks>
    class Reverse_Palindrome
    {
        static void Main(string[] args)
        {
            // Ask user to enter a number
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            // Store the original number for comparison later
            int originalNumber = number;

            int reverse = 0;

            // Reverse the number using while loop
            while (number > 0)
            {
                int digit = number % 10;        // Get last digit
                reverse = reverse * 10 + digit; // Build reversed number
                number = number / 10;           // Remove last digit
            }

            // Display the reversed number
            Console.WriteLine("Reversed Number: " + reverse);

            // Check if original number and reversed number are same
            if (originalNumber == reverse)
            {
                Console.WriteLine("It is a Palindrome Number");
            }
            else
            {
                Console.WriteLine("It is NOT a Palindrome Number");
            }
        }
    }
}
