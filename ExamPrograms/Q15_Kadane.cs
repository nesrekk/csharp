using System;

namespace Q15_Kadane
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by spaces: ");
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

            // Kadane: at each number, either add it to the current subarray or start fresh from it
            int current = a[0];
            int best = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                current = Math.Max(a[i], current + a[i]);
                best = Math.Max(best, current);
            }
            Console.WriteLine("Maximum subarray sum: " + best);
        }
    }
}
