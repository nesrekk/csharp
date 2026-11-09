using System;
using System.Collections.Generic;

namespace Q06_BalancedBrackets
{
    class Program
    {
        static bool IsBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                    stack.Push(c);
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0) return false;
                    char open = stack.Pop();
                    if ((c == ')' && open != '(') || (c == ']' && open != '[') || (c == '}' && open != '{'))
                        return false;
                }
            }
            return stack.Count == 0;   // nothing left open
        }

        static void Main()
        {
            Console.Write("Enter an expression: ");
            string s = Console.ReadLine();
            Console.WriteLine(IsBalanced(s) ? "Balanced" : "Not balanced");
        }
    }
}
