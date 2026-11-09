using System;
using System.Collections.Generic;

namespace Q08_TwoSum
{
    class Program
    {
        // For each number, check if (target - number) was already seen: O(n) with a dictionary
        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();   // value -> index
            for (int i = 0; i < nums.Length; i++)
            {
                int need = target - nums[i];
                if (seen.ContainsKey(need))
                    return new int[] { seen[need], i };
                seen[nums[i]] = i;
            }
            return null;
        }

        static void Main()
        {
            Console.Write("Enter numbers separated by spaces: ");
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] nums = Array.ConvertAll(parts, int.Parse);
            Console.Write("Enter target sum: ");
            int target = int.Parse(Console.ReadLine());

            int[] result = TwoSum(nums, target);
            if (result == null)
                Console.WriteLine("No two numbers add up to " + target);
            else
                Console.WriteLine($"Indices: [{result[0]}, {result[1]}]  ({nums[result[0]]} + {nums[result[1]]} = {target})");
        }
    }
}
