using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day5_Scenarios
{
        class Flip_Key
        {
            // Method to cleanse and invert the input string
            public string CleanseAndInvert(string input)
            {
                // Validation: null or length less than 6
                if (string.IsNullOrEmpty(input) || input.Length < 6)
                    return string.Empty;

                // Validation: only alphabets allowed
                foreach (char ch in input)
                {
                    if (!char.IsLetter(ch))
                        return string.Empty;
                }

                // Convert to lowercase
                input = input.ToLower();

                // Remove characters with even ASCII values
                StringBuilder filtered = new StringBuilder();
                foreach (char ch in input)
                {
                    if (((int)ch) % 2 != 0) // odd ASCII
                    {
                        filtered.Append(ch);
                    }
                }

                // Reverse the string
                char[] reversed = filtered.ToString().ToCharArray();
                Array.Reverse(reversed);

                // Uppercase characters at even positions
                for (int i = 0; i < reversed.Length; i++)
                {
                    if (i % 2 == 0)
                        reversed[i] = char.ToUpper(reversed[i]);
                }

                return new string(reversed);
            }

            // Main method
            static void Main(string[] args)
            {
                Flip_Key program = new Flip_Key();

                Console.WriteLine("Enter the word");
                string input = Console.ReadLine();

                string result = program.CleanseAndInvert(input);

                if (string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    Console.WriteLine("The generated key is - " + result);
                }

                Console.ReadLine();
            }
        }
}

