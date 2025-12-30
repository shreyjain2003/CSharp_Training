using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day8
{
        // 🔹 Extension class (must be static)
        public static class PalindromeStringExtensions
        {
            // 🔹 Extension Method
            public static bool IsPalindrome(this string text)
            {
                if (string.IsNullOrEmpty(text))
                    return false;

                text = text.ToLower();

                int start = 0;
                int end = text.Length - 1;

                while (start < end)
                {
                    if (text[start] != text[end])
                        return false;

                    start++;
                    end--;
                }
                return true;
            }
        }
}
