using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Represents a console application that displays a descriptive message based on a user-entered letter grade.
    /// </summary>
    /// <remarks>The application prompts the user to enter a single character representing a grade (E, V, G,
    /// A, or F) and outputs the corresponding description. If an invalid grade is entered, an error message is
    /// displayed. The input is case-insensitive.</remarks>
        class Grade_Description
        {
            static void Main(string[] args)
            {
                // Ask the user to enter a grade
                Console.WriteLine("Enter Grade (E, V, G, A, F): ");

                // Read the input and convert it to uppercase to handle lowercase input
                char grade = char.ToUpper(Console.ReadLine()[0]);

                // Switch statement to check grade and print description
                switch (grade)
                {
                    case 'E':
                        Console.WriteLine("Excellent");
                        break;

                    case 'V':
                        Console.WriteLine("Very Good");
                        break;

                    case 'G':
                        Console.WriteLine("Good");
                        break;

                    case 'A':
                        Console.WriteLine("Average");
                        break;

                    case 'F':
                        Console.WriteLine("Fail");
                        break;

                    default:
                        // Handles invalid grade input
                        Console.WriteLine("Invalid Grade Entered");
                        break;
                }

                // Keeps console window open until a key is pressed
                Console.ReadKey();
            }
        }
}
