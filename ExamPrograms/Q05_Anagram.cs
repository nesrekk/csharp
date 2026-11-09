using System;

namespace Q05_Anagram
{
    class Program
    {
        // Count each letter: +1 for the first string, -1 for the second; all counts must end at 0
        static bool AreAnagrams(string a, string b)
        {
            int[] count = new int[26];
            int letters = 0;
            foreach (char c in a.ToLower())
                if (c >= 'a' && c <= 'z') { count[c - 'a']++; letters++; }
            foreach (char c in b.ToLower())
                if (c >= 'a' && c <= 'z') { count[c - 'a']--; letters--; }
            if (letters != 0) return false;
            foreach (int n in count)
                if (n != 0) return false;
            return true;
        }

        static void Main()
        {
            Console.Write("Enter first string: ");
            string a = Console.ReadLine();
            Console.Write("Enter second string: ");
            string b = Console.ReadLine();
            Console.WriteLine(AreAnagrams(a, b) ? "The strings are anagrams" : "The strings are not anagrams");
        }
    }
}
