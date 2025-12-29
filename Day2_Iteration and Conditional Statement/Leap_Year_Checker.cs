using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Provides functionality to determine whether a given year is a leap year according to the Gregorian calendar.
    /// </summary>
    /// <remarks>A leap year is defined as a year that is divisible by 4, except for years that are divisible
    /// by 100, unless they are also divisible by 400. This class is intended for use in console applications that
    /// require leap year validation.</remarks>
    public class Leap_Year_Checker
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            /// Logic to check leap year
            if (year % 400 == 0)
            {
                Console.WriteLine(year + " is a Leap Year!");
            }
            else if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine(year + " is a Leap Year!");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year!");
            }
        }

    }
}
