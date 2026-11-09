using System;

namespace Q21_Permutations
{
    class Program
    {
        // Take each character in turn as the next letter, then permute the letters that are left
        static void Permute(string prefix, string rest)
        {
            if (rest.Length == 0)
            {
                Console.WriteLine(prefix);
                return;
            }
            for (int i = 0; i < rest.Length; i++)
            {
                string remaining = rest.Remove(i, 1);   // rest without the character at i
                Permute(prefix + rest[i], remaining);
            }
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            Console.WriteLine("Permutations:");
            Permute("", s);
        }
    }
}
