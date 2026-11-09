using System;

namespace Q02_First50Primes
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        static void Main()
        {
            Console.WriteLine("First 50 prime numbers:");
            int count = 0;
            for (int n = 2; count < 50; n++)
            {
                if (IsPrime(n))
                {
                    count++;
                    Console.Write(n + (count % 10 == 0 ? "\n" : " "));
                }
            }
        }
    }
}
