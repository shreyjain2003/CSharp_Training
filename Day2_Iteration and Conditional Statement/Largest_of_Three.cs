using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Provides a console application that prompts the user to enter three integers and displays the largest value.
    /// </summary>
    public class Largest_of_Three
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter first number: ");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third number: ");
            c=int.Parse(Console.ReadLine());
            /// Logic to find largest number among three
            if (a>b && a > c)
            {
                Console.WriteLine("Largest number is " + a);
            }
            else if(b>a && b > c)
            {
                Console.WriteLine("Largest number is " + b);
            }
            else
            {
                Console.WriteLine("Largest number is " + c);
            }
        }
    }
}
