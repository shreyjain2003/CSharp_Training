using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day8
{
        class UseFactorialExtensionMethod
        {
            static void Main()
            {
            Console.WriteLine("Enter number for Factorial: ");
            int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Factorial of {num} is {num.Factorial()}");
            }
        }
}
