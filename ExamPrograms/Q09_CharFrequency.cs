using System;
using System.Collections.Generic;

namespace Q09_CharFrequency
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            Dictionary<char, int> freq = new Dictionary<char, int>();
            List<char> order = new List<char>();          // remembers first-appearance order
            foreach (char c in s)
            {
                if (c == ' ') continue;
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                {
                    freq[c] = 1;
                    order.Add(c);
                }
            }

            Console.WriteLine("Character frequencies:");
            foreach (char c in order)
                Console.WriteLine($"'{c}' : {freq[c]}");
        }
    }
}
