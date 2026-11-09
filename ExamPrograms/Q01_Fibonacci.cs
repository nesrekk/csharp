using System;

namespace Q01_Fibonacci
{
    class Program
    {
        static void Main()
        {
            // long is needed: the 50th Fibonacci number (7778742049) is larger than int.MaxValue
            long a = 0, b = 1;
            Console.WriteLine("First 50 Fibonacci numbers:");
            for (int i = 1; i <= 50; i++)
            {
                Console.Write(a + (i % 10 == 0 ? "\n" : " "));
                long next = a + b;
                a = b;
                b = next;
            }
        }
    }
}
