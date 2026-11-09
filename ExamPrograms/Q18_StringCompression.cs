using System;

namespace Q18_StringCompression
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            string result = "";
            int i = 0;
            while (i < s.Length)
            {
                char c = s[i];
                int count = 0;
                while (i < s.Length && s[i] == c)   // count this run of the same character
                {
                    count++;
                    i++;
                }
                result = result + c + count;        // e.g. "a" + 2 -> "a2"
            }
            Console.WriteLine("Compressed: " + result);
        }
    }
}
