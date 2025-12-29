using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Provides functionality to validate whether a given day, month, and year constitute a valid calendar date.
    /// </summary>
    /// <remarks>This class prompts the user to enter a day, month, and year, and determines if the input
    /// represents a valid date, taking leap years into account. The validation logic checks for valid ranges of months
    /// and days, and adjusts for leap years when evaluating February. The result is displayed to the user via the
    /// console.</remarks>
        class Valid_Date_Check
        {
            static void Main(string[] args)
            {
                // Input day, month, and year from user
                Console.WriteLine("Enter Day:");
                int day = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Month:");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Year:");
                int year = int.Parse(Console.ReadLine());

                bool isValid = true;

                // Check valid month
                if (month < 1 || month > 12)
                {
                    isValid = false;
                }
                else
                {
                    // Days in each month
                    int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                    // Check for leap year
                    if (month == 2 && IsLeapYear(year))
                    {
                        daysInMonth[1] = 29;
                    }

                    // Check valid day
                    if (day < 1 || day > daysInMonth[month - 1])
                    {
                        isValid = false;
                    }
                }

                // Output result
                if (isValid)
                {
                    Console.WriteLine("Valid Date");
                }
                else
                {
                    Console.WriteLine("Invalid Date");
                }
            }

            // Method to check leap year
            static bool IsLeapYear(int year)
            {
                return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            }
        }
    

}
