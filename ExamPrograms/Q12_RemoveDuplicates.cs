using System;
using System.Collections.Generic;

namespace Q12_RemoveDuplicates
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by spaces: ");
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<int> result = new List<int>();
            foreach (string p in parts)
            {
                int x = int.Parse(p);
                if (!result.Contains(x))      // add only if we have not added it before
                    result.Add(x);
            }
            Console.WriteLine("Without duplicates: " + string.Join(" ", result));
        }
    }
}
