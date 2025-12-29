using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capgemini_Training
{
    class GCD_LCM
    {
        /// <summary>
        /// Serves as the entry point for the application. Prompts the user to enter two integers, then calculates and
        /// displays their greatest common divisor (GCD) and least common multiple (LCM).
        /// </summary>
        /// <param name="args">An array of command-line arguments. This parameter is not used.</param>
        static void Main(string[] args)
        {
            // Take first number input
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            // Take second number input
            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            // Store original values (needed later for LCM)
            int a = num1;
            int b = num2;

            // -------- GCD CALCULATION (Euclidean Algorithm) --------
            while (b != 0)
            {
                int remainder = a % b; // Find remainder
                a = b;                 // Update a
                b = remainder;         // Update b
            }

            int gcd = a; // Final value of a is GCD

            // -------- LCM CALCULATION --------
            int lcm = (num1 * num2) / gcd;

            // Display results
            Console.WriteLine("GCD = " + gcd);
            Console.WriteLine("LCM = " + lcm);
        }
    }
}
