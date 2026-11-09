using System;

namespace Q22_LongestUniqueSubstring
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            string longest = "";
            // Start at every position and grow the substring until a character repeats
            for (int i = 0; i < s.Length; i++)
            {
                string current = "";
                for (int j = i; j < s.Length; j++)
                {
                    if (current.Contains(s[j])) break;   // repeat found, stop growing
                    current = current + s[j];
                }
                if (current.Length > longest.Length)
                    longest = current;
            }
            Console.WriteLine("Longest substring without repeating characters: \"" + longest + "\"");
            Console.WriteLine("Length: " + longest.Length);
        }
    }
}
