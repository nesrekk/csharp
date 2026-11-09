using System;

namespace Q23_RotateArray
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by spaces: ");
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
            Console.Write("Rotate right by k = ");
            int k = int.Parse(Console.ReadLine());

            int n = a.Length;
            int[] result = new int[n];
            // Each element moves k places to the right; % n wraps it around to the front
            for (int i = 0; i < n; i++)
                result[(i + k) % n] = a[i];

            Console.WriteLine("Rotated: " + string.Join(" ", result));
        }
    }
}
