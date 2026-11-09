using System;

namespace Q11_FirstNonRepeating
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            // For each character, count how many times it appears in the whole string
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < s.Length; j++)
                    if (s[j] == s[i]) count++;

                if (count == 1)
                {
                    Console.WriteLine("First non-repeating character: '" + s[i] + "' at index " + i);
                    return;
                }
            }
            Console.WriteLine("Every character repeats");
        }
    }
}
