using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day8
{
        // 🔹 Extension class (must be static)
        public static class IntExtensions
        {
            // 🔹 Extension Method
            public static long Factorial(this int number)
            {
                if (number < 0)
                    throw new ArgumentException("Factorial not defined for negative numbers");

                long result = 1;

                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }

                return result;
            }
        }
}
