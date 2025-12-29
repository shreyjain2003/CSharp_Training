using System;

namespace Capgemini_Training
{
    /// <summary>
    /// Class to determine the type of triangle
    /// </summary>
    public class Triangle_Type
    {
        // Main method: Program execution starts here
        static void Main(string[] args)
        {
            // Ask the user to enter the first side of the triangle
            Console.WriteLine("Enter 1st Side of Triangle: ");
            int side1 = int.Parse(Console.ReadLine());

            // Ask the user to enter the second side of the triangle
            Console.WriteLine("Enter 2nd Side of Triangle: ");
            int side2 = int.Parse(Console.ReadLine());

            // Ask the user to enter the third side of the triangle
            Console.WriteLine("Enter 3rd Side of Triangle: ");
            int side3 = int.Parse(Console.ReadLine());

            // Check if all three sides are equal
            // If yes, the triangle is Equilateral
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Equilateral Triangle!");
            }
            // Check if all three sides are different
            // If yes, the triangle is Scalene
            else if (side1 != side2 && side2 != side3 && side3 != side1)
            {
                Console.WriteLine("Scalene Triangle!");
            }
            // If neither of the above conditions is true,
            // then exactly two sides are equal → Isosceles triangle
            else
            {
                Console.WriteLine("Isosceles Triangle!");
            }
        }
    }
}
