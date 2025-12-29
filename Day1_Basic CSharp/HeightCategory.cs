using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Provides functionality to categorize a person's height based on user input in centimeters.
    /// </summary>
    /// <remarks>This class is intended for console applications that prompt the user to enter their height
    /// and then display a corresponding height category. The categories are determined by predefined height
    /// ranges.</remarks>
    public class HeightCategory
    {
        /// <summary>
        /// Serves as the entry point for the application. Prompts the user to enter their height in centimeters and
        /// categorizes the height based on predefined ranges.
        /// </summary>
        /// <param name="args">An array of command-line arguments supplied to the application. This parameter is not used.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height in CM: ");
            int height=int.Parse(Console.ReadLine());
            
            if (height < 150)
            {
                Console.WriteLine("Dwarf");
            }
            else if(height>=150 && height < 165)
            {
                Console.WriteLine("Average");
            }
            else if(height>=165 && height < 190)
            {
                Console.WriteLine("Tall");
            }
            else
            {
                Console.WriteLine("Abnormal");
            }
        }
    }
}
