using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Provides a console application that converts a binary number, entered as a string, to its decimal equivalent.
    /// </summary>
    /// <remarks>This class is intended to be run as a standalone application. It prompts the user to input a
    /// binary number and displays the corresponding decimal value. Input validation is not performed; entering invalid
    /// binary strings may result in incorrect output or runtime errors.</remarks>
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            // Ask user to enter a binary number as a string
            Console.WriteLine("Enter a Binary Number:");
            string binary = Console.ReadLine();

            int decimalNumber = 0;   // To store the final decimal value
            int power = 1;           // Represents 2^0 initially

            // Loop from last digit to first digit of the binary string
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                // Convert character '0' or '1' to integer 0 or 1
                int digit = binary[i] - '0';

                // Add digit * current power of 2 to decimal number
                decimalNumber += digit * power;

                // Update power of 2 (multiply by 2)
                power *= 2;
            }

            // Display the decimal equivalent
            Console.WriteLine("Decimal Equivalent: " + decimalNumber);
        }
    }
}

