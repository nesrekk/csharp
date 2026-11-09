using System;
using System.Collections.Generic;

namespace Q24_ArrayIntersection
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first array: ");
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
            Console.Write("Enter second array: ");
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

            List<int> common = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j] && !common.Contains(a[i]))   // in both arrays, not added yet
                    {
                        common.Add(a[i]);
                        break;
                    }
                }
            }
            Console.WriteLine(common.Count > 0 ? "Common elements: " + string.Join(" ", common) : "No common elements");
        }
    }
}
