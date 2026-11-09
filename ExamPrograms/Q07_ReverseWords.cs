using System;
using System.Text;

namespace Q07_ReverseWords
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a sentence: ");
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                sb.Append(words[i]);
                if (i > 0) sb.Append(' ');
            }
            Console.WriteLine("Reversed: " + sb);
        }
    }
}
