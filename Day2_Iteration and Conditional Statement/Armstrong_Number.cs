using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Provides a console application for determining whether a given integer is an Armstrong number.
    /// </summary>
    /// <remarks>An Armstrong number is an integer such that the sum of its own digits each raised to the
    /// power of the number of digits equals the number itself. For example, 153 is an Armstrong number because 1^3 +
    /// 5^3 + 3^3 = 153.</remarks>
    class Armstrong_Number
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int original = num;
            int digits = num.ToString().Length;
            int sum = 0;

            // Calculate sum of digits raised to power of number of digits
            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, digits);
                num /= 10;
            }

            // Check Armstrong condition
            if (sum == original)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not an Armstrong Number");
        }
    }

}
