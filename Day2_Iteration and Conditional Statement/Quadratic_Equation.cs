using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Represents an entry point for solving quadratic equations using user-provided coefficients.
    /// </summary>
    /// <remarks>This class prompts the user to enter the coefficients of a quadratic equation and calculates
    /// the real or complex roots based on the discriminant. The application determines whether the equation has two
    /// distinct real roots, one real root, or complex roots, and displays the results accordingly. This class is
    /// intended for console-based demonstration and does not provide reusable methods or properties.</remarks>
        class Quadratic_Equation
        {
            static void Main(string[] args)
            {
            // Prompt user for coefficients
            Console.Write("Enter value of a: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Enter value of b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Enter value of c: ");
                double c = double.Parse(Console.ReadLine());
            // Check if 'a' is zero
            if (a == 0)
                {
                    Console.WriteLine("This is not a quadratic equation.");
                    return;
                }

                double discriminant = b * b - 4 * a * c;
            // Calculate and display roots based on discriminant
            if (discriminant > 0)
                {
                    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                    Console.WriteLine("Roots are real and distinct:");
                    Console.WriteLine($"Root 1 = {root1}");
                    Console.WriteLine($"Root 2 = {root2}");
                }
                else if (discriminant == 0)
                {
                    double root = -b / (2 * a);
                    Console.WriteLine("Roots are real and equal:");
                    Console.WriteLine($"Root = {root}");
                }
                else
                {
                    Console.WriteLine("Roots are complex (no real roots).");
                }
            }
        }
}
