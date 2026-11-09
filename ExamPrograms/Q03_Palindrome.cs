using System;

namespace Q03_Palindrome
{
    class Program
    {
        // Two pointers from both ends; case and non-letter/digit characters are ignored
        static bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (!char.IsLetterOrDigit(s[i])) { i++; continue; }
                if (!char.IsLetterOrDigit(s[j])) { j--; continue; }
                if (char.ToLower(s[i]) != char.ToLower(s[j])) return false;
                i++;
                j--;
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            Console.WriteLine(IsPalindrome(s) ? $"\"{s}\" is a palindrome" : $"\"{s}\" is not a palindrome");
        }
    }
}
