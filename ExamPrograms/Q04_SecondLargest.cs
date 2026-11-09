using System;

namespace Q04_SecondLargest
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by spaces: ");
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++) arr[i] = int.Parse(parts[i]);

            // One pass, no sorting: keep the largest and the second largest distinct value
            int largest = int.MinValue, second = int.MinValue;
            bool hasSecond = false;
            foreach (int x in arr)
            {
                if (x > largest)
                {
                    if (largest != int.MinValue) { second = largest; hasSecond = true; }
                    largest = x;
                }
                else if (x < largest && (!hasSecond || x > second))
                {
                    second = x;
                    hasSecond = true;
                }
            }

            Console.WriteLine("Largest: " + largest);
            Console.WriteLine(hasSecond ? "Second largest: " + second : "There is no second largest (all values are equal)");
        }
    }
}
