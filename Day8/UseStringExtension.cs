using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day8
{
        class UseStringExtension
        {
            static void Main()
            {
            Console.WriteLine("Enter the Word: ");
            string word = Console.ReadLine();


            if (word.IsPalindrome())
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a Palindrome");
            }
        }
}
