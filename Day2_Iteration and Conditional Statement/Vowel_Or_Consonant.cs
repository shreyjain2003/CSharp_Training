using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Provides a console application that determines whether a user-entered character is a vowel or a consonant.
    /// </summary>
    /// <remarks>This class is intended for demonstration or educational purposes and is not designed for use
    /// as a reusable library component.</remarks>
    class Vowel_Or_Consonant
    {
        static void Main(string[] args)
        {
            // Ask user to enter a character
            Console.Write("Enter a character: ");
            char ch = char.ToLower(Console.ReadLine()[0]);

            // Switch statement to check vowel
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("It is a Vowel");
                    break;

                default:
                    Console.WriteLine("It is a Consonant");
                    break;
            }

            Console.ReadLine(); // Hold console window
        }
    }
}
