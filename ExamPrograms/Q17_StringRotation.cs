using System;

namespace Q17_StringRotation
{
    class Program
    {
        // If s2 is a rotation of s1, then s2 always appears inside s1 + s1
        static bool IsRotation(string s1, string s2)
        {
            return s1.Length == s2.Length && s1.Length > 0 && (s1 + s1).Contains(s2);
        }

        static void Main()
        {
            Console.Write("Enter first string: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string s2 = Console.ReadLine();
            Console.WriteLine(IsRotation(s1, s2)
                ? $"\"{s2}\" is a rotation of \"{s1}\""
                : $"\"{s2}\" is not a rotation of \"{s1}\"");
        }
    }
}
