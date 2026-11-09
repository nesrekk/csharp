using System;

namespace Q13_Armstrong
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            int digits = n.ToString().Length;     // e.g. 153 has 3 digits
            int sum = 0;
            int temp = n;
            while (temp > 0)
            {
                int d = temp % 10;                // last digit
                sum += (int)Math.Pow(d, digits);  // digit raised to the number of digits
                temp = temp / 10;                 // remove the last digit
            }

            if (sum == n)
                Console.WriteLine(n + " is an Armstrong number");
            else
                Console.WriteLine(n + " is not an Armstrong number");
        }
    }
}
