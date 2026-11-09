using System;

namespace Q16_MergeSortedArrays
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first sorted array: ");
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
            Console.Write("Enter second sorted array: ");
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

            int[] result = new int[a.Length + b.Length];
            int i = 0, j = 0, k = 0;

            // Compare the front of both arrays and copy the smaller one
            while (i < a.Length && j < b.Length)
            {
                if (a[i] <= b[j])
                {
                    result[k] = a[i];
                    i++;
                }
                else
                {
                    result[k] = b[j];
                    j++;
                }
                k++;
            }
            // Copy whatever is left in either array
            while (i < a.Length) { result[k] = a[i]; i++; k++; }
            while (j < b.Length) { result[k] = b[j]; j++; k++; }

            Console.WriteLine("Merged: " + string.Join(" ", result));
        }
    }
}
