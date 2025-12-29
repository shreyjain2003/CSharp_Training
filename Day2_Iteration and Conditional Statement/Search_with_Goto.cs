using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Demonstrates searching for a user-specified number within a three-dimensional array using nested loops and a
    /// goto statement to exit all loops upon finding the target value.
    /// </summary>
    /// <remarks>This example illustrates the use of the goto statement to break out of multiple nested loops
    /// when a match is found. The program prompts the user to enter a number, searches for it in a sample 3D array, and
    /// displays the position if found. If the number is not present, a message is shown indicating that the number was
    /// not found.</remarks>
    class Search_With_Goto
    {
        static void Main(string[] args)
        {
            #region Input Section
            // Sample 3D array to demonstrate deep nested loops
            int[,,] numbers =
            {
                { {1, 2}, {3, 4} },
                { {5, 6}, {7, 8} }
            };

            Console.Write("Enter number to search: ");
            int target = int.Parse(Console.ReadLine());

            bool found = false;
            #endregion
            
            #region Search Logic (Nested Loops + GOTO)
            // Searching through a 3D array using nested loops
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.GetLength(2); k++)
                    {
                        if (numbers[i, j, k] == target)
                        {
                            Console.WriteLine($"Number found at position [{i},{j},{k}]");
                            found = true;

                            // Exit all loops instantly
                            goto EndSearch;
                        }
                    }
                }
            }
        #endregion

        #region Result Section
        EndSearch:

            if (!found)
            {
                Console.WriteLine("Number not found in the array.");
            }
            #endregion
        }
    }
}
