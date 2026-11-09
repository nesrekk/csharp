using System;

namespace Q10_MissingNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Enter the {n - 1} numbers (1 to {n}, one missing): ");
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Sum of 1..N is N(N+1)/2; whatever is missing from that total is the answer
            long expected = (long)n * (n + 1) / 2;
            long actual = 0;
            foreach (string p in parts) actual += int.Parse(p);

            Console.WriteLine("Missing number: " + (expected - actual));
        }
    }
}
