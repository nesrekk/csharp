using System;

namespace Q14_BinarySearch
{
    class Program
    {
        static int SearchIterative(int[] a, int key)
        {
            int low = 0, high = a.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (a[mid] == key) return mid;
                if (a[mid] < key) low = mid + 1;
                else high = mid - 1;
            }
            return -1;
        }

        static int SearchRecursive(int[] a, int key, int low, int high)
        {
            if (low > high) return -1;
            int mid = low + (high - low) / 2;
            if (a[mid] == key) return mid;
            if (a[mid] < key) return SearchRecursive(a, key, mid + 1, high);
            return SearchRecursive(a, key, low, mid - 1);
        }

        static void Main()
        {
            Console.Write("Enter sorted numbers separated by spaces: ");
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
            Console.Write("Enter number to search: ");
            int key = int.Parse(Console.ReadLine());

            int i1 = SearchIterative(a, key);
            int i2 = SearchRecursive(a, key, 0, a.Length - 1);
            Console.WriteLine(i1 >= 0 ? $"Iterative: found {key} at index {i1}" : $"Iterative: {key} not found");
            Console.WriteLine(i2 >= 0 ? $"Recursive: found {key} at index {i2}" : $"Recursive: {key} not found");
        }
    }
}
