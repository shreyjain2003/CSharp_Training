using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Class to determine the quadrant of a point (x, y)
    /// </summary>
    public class Quadrant_Finder
    {
        // Main method: Entry point of the program
        static void Main(string[] args)
        {
            // Ask the user to enter the X coordinate
            Console.WriteLine("Enter X Co-ordinate: ");
            double x = double.Parse(Console.ReadLine());

            // Ask the user to enter the Y coordinate
            Console.WriteLine("Enter Y Co-ordinate: ");
            double y = double.Parse(Console.ReadLine());

            // Check if both x and y are positive
            if (x > 0 && y > 0)
            {
                Console.WriteLine("1st Quadrant!");
            }
            // Check if x is negative and y is positive
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2nd Quadrant!");
            }
            // Check if both x and y are negative
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3rd Quadrant!");
            }
            // If x is positive and y is negative
            else
            {
                Console.WriteLine("4th Quadrant!");
            }
        }
    }
}
