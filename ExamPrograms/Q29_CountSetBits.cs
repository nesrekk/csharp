using System;

namespace Q29_CountSetBits
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary: " + Convert.ToString(number, 2));

            uint n = (uint)number;   // uint so negative numbers also work
            int count = 0;
            while (n > 0)
            {
                if (n % 2 == 1) count++;   // last binary digit is 1
                n = n / 2;                 // drop the last binary digit
            }
            Console.WriteLine("Number of set bits: " + count);
        }
    }
}
