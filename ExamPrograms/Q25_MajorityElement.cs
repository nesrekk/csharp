using System;

namespace Q25_MajorityElement
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by spaces: ");
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

            // Count how often each number appears; the majority appears more than n/2 times
            for (int i = 0; i < a.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < a.Length; j++)
                    if (a[j] == a[i]) count++;

                if (count > a.Length / 2)
                {
                    Console.WriteLine("Majority element: " + a[i] + " (appears " + count + " of " + a.Length + " times)");
                    return;
                }
            }
            Console.WriteLine("No majority element");
        }
    }
}
