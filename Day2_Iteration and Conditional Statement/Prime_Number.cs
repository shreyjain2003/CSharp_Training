using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capgemini_Training
{
    /// <summary>
    /// Provides a console application for determining whether a user-supplied integer is a prime number.
    /// </summary>
    /// <remarks>This class contains the application's entry point and prompts the user to enter a number via
    /// the console. It then evaluates whether the entered value is a prime number and displays the result. The class is
    /// intended for demonstration or educational purposes and is not designed for use as a reusable library
    /// component.</remarks>
    class Prime_Number
    {
        static void Main(string[] args)
        {
            // Ask user to enter a number
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            // Prime numbers are greater than 1
            if (num <= 1)
            {
                Console.WriteLine("Not a Prime Number");
                return; // Exit the program
            }

            bool isPrime = true; // Flag variable to track primality

            // Check divisibility from 2 to num-1
            for (int i = 2; i < num; i++)
            {
                // If number is divisible by any i, it's not prime
                if (num % i == 0)
                {
                    isPrime = false;
                    break; // Exit loop as divisor is found
                }
            }

            // Print result based on flag value
            if (isPrime)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}
