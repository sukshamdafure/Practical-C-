using System;
using System.Collections.Generic;

class BalancedParentheses
{
    static void Main()
    {
        string input;

        Console.Write("Enter expression: ");
        input = Console.ReadLine();

        Stack<char> stack = new Stack<char>();

        bool isBalanced = true;

        foreach (char ch in input)
        {
            if (ch == '(')
            {
                stack.Push(ch);
            }
            else if (ch == ')')
            {
                if (stack.Count == 0)
                {
                    isBalanced = false;
                    break;
                }
                stack.Pop();
            }
        }

        if (stack.Count != 0)
            isBalanced = false;

        if (isBalanced)
            Console.WriteLine("Balanced Parentheses");
        else
            Console.WriteLine("Not Balanced Parentheses");
    }
}